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

namespace PostGIS3DExplorer
{
  public partial class SQLEditorControl : UserControl
  {
    private NumberFormatInfo pEnUs = CultureInfo.GetCultureInfo("en-us").NumberFormat;
    private NumberFormatInfo pDutch = CultureInfo.GetCultureInfo("nl-nl").NumberFormat;

    public vtkActor Actor { get; set; }
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

    private void SQLExecute(string sSQL)
    {
      vtkAppendPolyData pvtkAppendPolyData = null;
      vtkPolygon pPolygonCell = null;
      vtkPoints pvtkPoints = null;
      vtkPointSource pvtkPointSource = null;
      vtkCellArray pvtkCellArray = null;
      vtkIdList pvtkIdList = null;

      DBHelper pDBHelper = new DBHelper(m_pPostGISConnectionParams);

      try
      {

        DataTable p3DDataTable = pDBHelper.GetDataTable(sSQL, "3D_objects", false);
        string sLine = "";

        int iRow = 0;
        foreach (DataRow pRow in p3DDataTable.Rows)
        {
          sLine = pRow[0].ToString();
          if (sLine.StartsWith("POLYGON Z") || sLine.StartsWith("TRIANGLE Z"))
          {
            if (pvtkAppendPolyData == null)
            {
              pvtkAppendPolyData = vtkAppendPolyData.New();
            }
            sLine = sLine.Replace("TRIANGLE Z ((", "");
            sLine = sLine.Replace("POLYGON Z ((", "");
            sLine = sLine.Replace("))", "");
            sLine = sLine.Replace("),(", "");

            pvtkPoints = vtkPoints.New();
            pPolygonCell = vtkPolygon.New();
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
                pPolygonCell.GetPointIds().InsertId(iPoint, iPoint);
              }
            }
            catch (Exception ex)
            {

            }
            vtkCellArray pCellArray = vtkCellArray.New();
            pCellArray.InsertNextCell(pPolygonCell);

            vtkPolyData pPolyData = vtkPolyData.New();
            pPolyData.SetPoints(pvtkPoints);
            pPolyData.SetPolys(pCellArray);

            pvtkAppendPolyData.AddInput(pPolyData);
          }
          else if (sLine.StartsWith("POINT Z"))
          {
            if (pvtkCellArray == null)
            {
              pvtkCellArray = vtkCellArray.New();
              pvtkPoints = vtkPoints.New();
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
          }
          iRow++;
        }

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
          pvtkPolyDataMapper.SetInput(pvtkPolyData);
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
      catch (Exception ex)
      {
        MaterialMessageBox.Show("Er ging iets fout!\n\n" + ex.Message, "SQL fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      pDBHelper.Connection.Close();
      pDBHelper = null;
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
        //Application.DoEvents();
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
        double red = (double)rbtnFillColor.Color.R / 255;
        double green = (double)rbtnFillColor.Color.G / 255;
        double blue = (double)rbtnFillColor.Color.B / 255;

        this.Actor.GetProperty().SetColor(red, green, blue);

        Actor.GetProperty().SetPointSize(6);

        //Actor.GetProperty().GetClassName();

        if (rbtnOutline.Checked)
        {
          this.Actor.GetProperty().SetEdgeVisibility(1);
        }
        else
        {
          this.Actor.GetProperty().SetEdgeVisibility(0);
        }
        //this.Actor.GetProperty().SetOpacity(1);

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

