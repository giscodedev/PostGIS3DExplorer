using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Kitware.VTK;
using System.Globalization;
using MaterialSkin.Controls;
using System.Threading;
using Npgsql;

namespace PostGIS3DExplorer
{
  public enum ActorType
  {
    Polygon,
    PolyLine,
    Point
  }

  public partial class SQLEditorControl : UserControl
  {
    private NumberFormatInfo pEnUs = CultureInfo.GetCultureInfo("en-us").NumberFormat;
    private NumberFormatInfo pDutch = CultureInfo.GetCultureInfo("nl-nl").NumberFormat;

    public vtkActor Actor { get; set; }
    public ActorType actorType;

    public RenderWindowControl RenderWindowControl { get; set; }

    private PostGISConnectionParams m_pPostGISConnectionParams = new PostGISConnectionParams();
    public PostGISConnectionParams PostGISConnectionParams
    {
      get { return m_pPostGISConnectionParams; }
      set { m_pPostGISConnectionParams = value; }
    }

    public SQLEditorControl()
    {
      InitializeComponent();
      fastColoredTextBox1.Language = Language.SQL;

      fastColoredTextBox1.Text = "select st_astext(\n  (st_dump((st_extrude( st_expand(st_geomfromtext('point(0 0)', 28992), 5, 5), 0, 0, 10)))).geom\n  )";
      fastColoredTextBox1.Refresh();

      this.ribbon1.Font = Program.materialSkinManager.ROBOTO_MEDIUM_10;
      this.ribbon1.RibbonTabFont = Program.materialSkinManager.ROBOTO_MEDIUM_10;
    }


    private void SQLEditorControl_Load(object sender, EventArgs e)
    {
      if (this.ParentForm != null)
      {
        if (this.ParentForm is FrmMain)
        {
          FrmMain pFrmMain = this.ParentForm as FrmMain;
          pFrmMain.SwitchLanguage += new EventHandler(this.SwitchLanguage);
        }
      }
    }

    private void SwitchLanguage(object sender, EventArgs e)
    {
      SwitchLanguageEventArgs pSwitchLanguageEventArgs = e as SwitchLanguageEventArgs;

      rbtnExecute.Text = Program.resourceManager.GetString("QUERY_EXECUTE", pSwitchLanguageEventArgs.CultureInfo);
      rbtnDelete.Text = Program.resourceManager.GetString("QUERY_REMOVE", pSwitchLanguageEventArgs.CultureInfo);
      rbtnOutline.Text = Program.resourceManager.GetString("QUERY_OUTLINE", pSwitchLanguageEventArgs.CultureInfo);
      rbtnFillColor.Text = Program.resourceManager.GetString("QUERY_FILLCOLOR", pSwitchLanguageEventArgs.CultureInfo);
      rbtnPointSize.Text = Program.resourceManager.GetString("QUERY_POINTSIZE", pSwitchLanguageEventArgs.CultureInfo);
      rbtnTransparancy.Text = Program.resourceManager.GetString("QUERY_TRANSPARANCY", pSwitchLanguageEventArgs.CultureInfo);
    }

    public FrmMain FrmMain
    {
      get; set;
    }

    public Color FillColor
    {
      get { return rbtnFillColor.Color; }
      set { rbtnFillColor.Color = value; }
    }

    public bool Outline
    {
      get { return rbtnOutline.Checked; }
      set { rbtnOutline.Checked = value; }
    }

    public string Query
    {
      get { return fastColoredTextBox1.Text; }
      set { fastColoredTextBox1.Text = value; }
    }

    public int PointSize
    {
      get
      {
        string sText = rbtnPointSize.TextBoxText;
        int iValue = 6;
        if (!Int32.TryParse(sText, out iValue))
        {
          iValue = 6;
        }
        if (iValue > 15) iValue = 15;
        if (iValue < 1) iValue = 1;
        return iValue;
      }
      set
      {
        rbtnPointSize.TextBoxText = value.ToString();
      }
    }

    private void SQLExecute(string sSQL)
    {
      vtkAppendPolyData pvtkAppendPolyData = null;
      vtkPolygon pvtkPolygon = null;
      vtkPolyLine pvtkPolyLine = null;
      vtkPoints pvtkPoints = null;
      vtkCellArray pvtkCellArray = null;
      vtkIdList pvtkIdList = null;

      // Color by RGB per point (works for meshes and points!)
      // https://www.vtk.org/Wiki/VTK/Examples/CSharp/Meshes/Color_a_mesh_by_height 
      vtkUnsignedCharArray rgb = null;
      bool bRGB = false;

      try
      {
        DataTable p3DDataTable = null;
        FrmQuery pFrmQuery = new FrmQuery();
        pFrmQuery.SQL = fastColoredTextBox1.Text;
        pFrmQuery.PostGISConnectionParams = m_pPostGISConnectionParams;
        if (pFrmQuery.ShowDialog(this.ParentForm) == DialogResult.OK)
        {
          p3DDataTable = pFrmQuery.DataTable;
        }
       
        if (p3DDataTable != null)
        {
          prgMain.Minimum = 0;
          prgMain.Maximum = 100;
          prgMain.Value = prgMain.Minimum;
          Application.DoEvents();

          string sLine = "";

          if (p3DDataTable.Columns["r"] != null && p3DDataTable.Columns["g"] != null && p3DDataTable.Columns["b"] != null)
          {
            bRGB = true;
          }

          int iRow = 0;
          foreach (DataRow pRow in p3DDataTable.Rows)
          {
            sLine = pRow[0].ToString();
            if (sLine.StartsWith("POLYGON Z") || sLine.StartsWith("TRIANGLE Z"))
            {
              //// Color by RGB per point
              //rgb = vtkUnsignedCharArray.New();
              //rgb.SetNumberOfComponents(3);
              //rgb.SetName("Color");

              if (pvtkAppendPolyData == null)
              {
                actorType = ActorType.Polygon;
                pvtkAppendPolyData = vtkAppendPolyData.New();
              }
              sLine = sLine.Replace("TRIANGLE Z ((", "");
              sLine = sLine.Replace("POLYGON Z ((", "");
              sLine = sLine.Replace("))", "");
              sLine = sLine.Replace("),(", "");

              pvtkPoints = vtkPoints.New();
              pvtkPolygon = vtkPolygon.New();
              try
              {
                string[] sCoOrdinates = sLine.Split(',');
                for (int iPoint = 0; iPoint < sCoOrdinates.Length; iPoint++)
                {
                  string[] sOrdinates = sCoOrdinates[iPoint].Trim().Split(' ');
                  if (sOrdinates.Length == 3) // Expect x,y,z
                  {
                    double x = double.Parse(sOrdinates[0], pEnUs);
                    double y = double.Parse(sOrdinates[1], pEnUs);
                    double z = double.Parse(sOrdinates[2], pEnUs);
                    pvtkPoints.InsertNextPoint(x, y, z);

                    //// Color by RGB per point
                    //if (z > 2)
                    //{
                    //  rgb.InsertNextTuple3(255, 200, 30);
                    //}
                    //else
                    //{
                    //  rgb.InsertNextTuple3(55, 200, 230);
                    //}
                  }
                  pvtkPolygon.GetPointIds().InsertId(iPoint, iPoint);
                }
              }
              catch (Exception ex)
              {

              }
              vtkCellArray pCellArray = vtkCellArray.New();
              pCellArray.InsertNextCell(pvtkPolygon);

              vtkPolyData pPolyData = vtkPolyData.New();
              pPolyData.SetPoints(pvtkPoints);
              pPolyData.SetPolys(pCellArray);

              //// Color by RGB per point
              //pPolyData.GetPointData().SetScalars(rgb);

              pvtkAppendPolyData.AddInputData(pPolyData);
            }
            else if (sLine.StartsWith("LINESTRING Z"))
            {
              if (pvtkAppendPolyData == null)
              {
                actorType = ActorType.PolyLine;
                pvtkAppendPolyData = vtkAppendPolyData.New();
              }
              sLine = sLine.Replace("LINESTRING Z (", "");
              sLine = sLine.Replace(")", "");

              pvtkPoints = vtkPoints.New();
              pvtkPolyLine = vtkPolyLine.New();
              try
              {
                string[] sCoOrdinates = sLine.Split(',');
                for (int iPoint = 0; iPoint < sCoOrdinates.Length; iPoint++)
                {
                  string[] sOrdinates = sCoOrdinates[iPoint].Trim().Split(' ');
                  if (sOrdinates.Length == 3) // Expect x,y,z
                  {
                    double x = double.Parse(sOrdinates[0], pEnUs);
                    double y = double.Parse(sOrdinates[1], pEnUs);
                    double z = double.Parse(sOrdinates[2], pEnUs);
                    pvtkPoints.InsertNextPoint(x, y, z);
                  }
                  pvtkPolyLine.GetPointIds().InsertId(iPoint, iPoint);
                }
              }
              catch (Exception ex)
              {

              }
              vtkCellArray pCellArray = vtkCellArray.New();
              pCellArray.InsertNextCell(pvtkPolyLine);

              vtkPolyData pPolyData = vtkPolyData.New();

              pPolyData.SetPoints(pvtkPoints);
              pPolyData.SetLines(pCellArray);

              //pvtkAppendPolyData.AddInput(pPolyData);
              pvtkAppendPolyData.AddInputData(pPolyData);
            }
            else if (sLine.StartsWith("POINT Z"))
            {
              if (pvtkCellArray == null)
              {
                actorType = ActorType.Point;
                pvtkCellArray = vtkCellArray.New();
                pvtkPoints = vtkPoints.New();

                if (bRGB)
                {
                  // Color by RGB per point
                  rgb = vtkUnsignedCharArray.New();
                  rgb.SetNumberOfComponents(3);
                  rgb.SetName("Color");
                }
              }

              sLine = sLine.Replace("POINT Z (", "");
              sLine = sLine.Replace(")", "");

              string[] sOrdinates = sLine.Split(' ');

              double x = double.Parse(sOrdinates[0], pEnUs);
              double y = double.Parse(sOrdinates[1], pEnUs);
              double z = double.Parse(sOrdinates[2], pEnUs);
              int iPnt = pvtkPoints.InsertNextPoint(x, y, z);

              pvtkIdList = vtkIdList.New();
              pvtkIdList.InsertNextId(iPnt);
              pvtkCellArray.InsertNextCell(pvtkIdList);

              if (bRGB)
              {
                if (!pRow.IsNull("r") && !pRow.IsNull("g") && !pRow.IsNull("b"))
                {
                  int r = Int32.Parse(pRow["r"].ToString());
                  int g = Int32.Parse(pRow["g"].ToString());
                  int b = Int32.Parse(pRow["b"].ToString());
                  rgb.InsertNextTuple3(r, g, b);
                }
                else
                {
                  rgb.InsertNextTuple3(0, 0, 0);
                }
              }
              //// Color by RGB per point
              //if (z > 2)
              //{
              //  rgb.InsertNextTuple3(255, 200, 30);
              //}
              //else
              //{
              //  rgb.InsertNextTuple3(55, 200, 230);
              //}


            }
            iRow++;

            int iPercent = (int)Math.Round((decimal)iRow / ((decimal)p3DDataTable.Rows.Count / (decimal)100), 0);
            prgMain.Value = iPercent;
            Application.DoEvents();
          }

          prgMain.Value = prgMain.Minimum;
          Application.DoEvents();

          vtkRenderer pvtkRenderer = null;
          vtkRenderWindow pvtkRenderWindow = null;

          // Create Components of the rendering subsystem
          pvtkRenderer = this.RenderWindowControl.RenderWindow.GetRenderers().GetFirstRenderer();
          pvtkRenderWindow = this.RenderWindowControl.RenderWindow;

          // Create a Mapper
          vtkPolyDataMapper pvtkPolyDataMapper = vtkPolyDataMapper.New();
          if (pvtkAppendPolyData != null)
          {
            pvtkPolyDataMapper.SetInputConnection(pvtkAppendPolyData.GetOutputPort());
          }
          else if (pvtkAppendPolyData == null && pvtkPoints != null)
          {
            vtkPolyData pvtkPolyData = vtkPolyData.New();
            pvtkPolyData.SetPoints(pvtkPoints);
            pvtkPolyData.SetVerts(pvtkCellArray);

            if (bRGB)
            {
              // Color by RGB per point
              pvtkPolyData.GetPointData().SetScalars(rgb);
            }

            pvtkPolyDataMapper.SetInputData(pvtkPolyData);
          }

          // Remove current Actor if present
          if (Actor != null)
          {
            try
            {
              vtkPropCollection p = pvtkRenderer.GetViewProps();
              pvtkRenderer.RemoveViewProp(Actor);
            }
            catch (Exception exRemove) { /* ignore for now */}
          }

          // Create new Actor
          Actor = vtkActor.New();

          // Perhaps use volume instead?
          // http://scipy-cookbook.readthedocs.io/items/vtkVolumeRendering.html
          //vtkVolume pvtkVolume = new vtkVolume();
          //pvtkVolume.SetMapper()

          Actor.SetMapper(pvtkPolyDataMapper);
          Actor.SetVisibility(1);

          // Add Actor to View as a "Prop"
          pvtkRenderer.AddViewProp(Actor);

          if (pvtkRenderer.VisibleActorCount() == 1)
          {
            // Setup Camera etc.
            pvtkRenderer.ResetCamera();
            pvtkRenderer.SetAmbient(1, 1, 1);
            pvtkRenderer.LightFollowCameraOn();

            //renWin.Render();
            vtkCamera pvtkCamera = pvtkRenderer.GetActiveCamera();
            pvtkCamera.Zoom(1.0D);
            pvtkRenderer.LightFollowCameraOn();
            pvtkRenderer.SetLightFollowCamera(1);
          }


          SetActorColor();

        }
      }
      catch (Exception ex)
      {
        MaterialMessageBox.Show("Er ging iets fout!\n\n" + ex.Message, "SQL fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    public void Execute()
    {
      btnExecute_Click(this, null);
    }

    private void btnExecute_Click(object sender, EventArgs e)
    {
      try
      {
        SQLExecute(fastColoredTextBox1.Text);
      }
      catch (Exception ex)
      {
        MessageBox.Show(this, "De vraag bevat een fout:\n\n" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
      }
    }

    public void btnRemove_Click(object sender, EventArgs e)
    {
      try
      {
        if (this.Actor != null)
        {
          vtkRenderer ren1 = null;
          vtkRenderWindow renWin = null;
          // Create components of the rendering subsystem
          ren1 = this.RenderWindowControl.RenderWindow.GetRenderers().GetFirstRenderer();
          renWin = this.RenderWindowControl.RenderWindow;

          vtkPropCollection p = ren1.GetViewProps();
          ren1.RemoveViewProp(this.Actor);
          this.Actor = null;

          this.RenderWindowControl.Refresh();
        }
      }
      catch (Exception ex)
      {
      }
    }

    private void rbtnOutline_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Actor != null)
      {
        SetActorColor();
      }
    }

    private void SetActorColor()
    {
      if (this.Actor != null)
      {
        double alpha = (double)this.Opacity / 100;
        this.Actor.GetProperty().SetOpacity(alpha);

        double red = (double)rbtnFillColor.Color.R / 255;
        double green = (double)rbtnFillColor.Color.G / 255;
        double blue = (double)rbtnFillColor.Color.B / 255;

        this.Actor.GetProperty().SetColor(red, green, blue);

        if (actorType == ActorType.Polygon)
        {
          this.Actor.GetProperty().SetColor(red, green, blue);
          if (rbtnOutline.Checked)
          {
            this.Actor.GetProperty().SetEdgeVisibility(1);
          }
          else
          {
            this.Actor.GetProperty().SetEdgeVisibility(0);
          }
        }
        else if (actorType == ActorType.PolyLine)
        {
          this.Actor.GetProperty().SetColor(red, green, blue);
          int iLineWidth = 2;
          if (this.PointSize > 1)
          {
            iLineWidth = this.PointSize;
          }
          Actor.GetProperty().SetLineWidth(iLineWidth);
          Actor.GetProperty().SetRenderLinesAsTubes(true);
          //Actor.GetProperty().set
        }
        else if (actorType == ActorType.Point)
        {
          if (rbtnOutline.Checked)
          {
            this.Actor.GetProperty().SetEdgeVisibility(1);
          }
          else
          {
            this.Actor.GetProperty().SetEdgeVisibility(0);
          }
          Actor.GetProperty().SetPointSize(this.PointSize);
          Actor.GetProperty().SetRenderPointsAsSpheres(true);
        }

        //Actor.GetProperty().GetClassName();


        //this.Actor.GetProperty().SetOpacity(0.95);

        // Specular is reflective value
        //this.Actor.GetProperty().SetSpecular(0.9);

        //this.Actor.GetProperty().SetSpecularColor(red, green, blue);


        //this.Actor.GetProperty().SetAmbient(0.4);
        //this.Actor.GetProperty().SetAmbientColor(red, green, blue);

        //this.Actor.GetProperty().LoadMaterial()
        RenderWindowControl.RenderWindow.Render();

      }
    }

    private void rbtnFillColor_Click(object sender, EventArgs e)
    {
      RibbonColorChooser pCChooser = sender as RibbonColorChooser;
      if (pCChooser == rbtnFillColor)
      {
        colorDialog1.Color = rbtnFillColor.Color;
      }

      if (colorDialog1.ShowDialog() == DialogResult.OK)
      {
        if (pCChooser == rbtnFillColor)
        {
          rbtnFillColor.Color = colorDialog1.Color;
          SetActorColor();
        }
      }
    }

    private void ribbonUpDown1_UpButtonClicked(object sender, MouseEventArgs e)
    {
      int iValue = this.PointSize + 1;
      rbtnPointSize.TextBoxText = iValue.ToString();
      SetActorColor();
    }

    private void ribbonUpDown1_DownButtonClicked(object sender, MouseEventArgs e)
    {
      if (this.PointSize == 1)
      {
        return;
      }
      int iValue = this.PointSize - 1;
      rbtnPointSize.TextBoxText = iValue.ToString();
      SetActorColor();
    }

    public int Opacity
    {
      get
      {
        int iAlpha = 100;
        if (!Int32.TryParse(rbtnTransparancy.TextBoxText, out iAlpha))
        {
          iAlpha = 100;
        }
        return iAlpha;
      }
      set
      {
        int iAlpha = value;
        if (iAlpha < 10)
        {
          iAlpha = 100;
        }
        if (iAlpha > 100)
        {
          iAlpha = 100;
        }
        rbtnTransparancy.TextBoxText = iAlpha.ToString();
      }
    }

    private void rbtnTransparancy_UpButtonClicked(object sender, MouseEventArgs e)
    {
      Opacity += 5;
      SetActorColor();
    }

    private void rbtnTransparancy_DownButtonClicked(object sender, MouseEventArgs e)
    {
      Opacity -= 5;
      SetActorColor();
    }
  }

  public class SQLActorEventArgs : EventArgs
  {
    public string sql { get; private set; }
    public SQLActorEventArgs(string sql)
    {
      this.sql = sql;
    }
  }

  public class ColorEventArgs : EventArgs
  {
    public Color color { get; private set; }
    public bool outline { get; private set; }
    public ColorEventArgs(Color color, bool outline)
    {
      this.color = color;
      this.outline = outline;
    }
  }
}

