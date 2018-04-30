using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Kitware.VTK;
using System.IO;
using System.Reflection;

namespace PostGIS3DExplorer
{
  public partial class FrmMain : MaterialForm
  {
    protected MruStripMenuInline m_pMruMenu;
    private string m_sProjectFileName = "";

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      if (keyData == Keys.F2)
      {
        if (advancedTreeView1.SelectedNode != null)
        {
          advancedTreeView1.SelectedNode.BeginEdit();
        }
        return true;
      }
      return base.ProcessCmdKey(ref msg, keyData);
    }

    public FrmMain()
    {
      InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      advancedTreeView1.Font = Program.materialSkinManager.ROBOTO_MEDIUM_11;
      advancedTreeView1.SelectedFocusColor = Program.selectionColor;
      advancedTreeView1.SelectedLostFocusColor = Color.LightGray;
      advancedTreeView1.Nodes.Clear();

      this.ribbon1.Font = Program.materialSkinManager.ROBOTO_MEDIUM_10;
      this.ribbon1.RibbonTabFont = Program.materialSkinManager.ROBOTO_MEDIUM_10;
      Theme.ColorTable.ButtonPressed_2013 = Program.selectionColor;
      Theme.ColorTable.ButtonSelected_2013 = Program.selectionColor;
      Theme.ColorTable.TabText_2013 = Program.materialSkinManager.ColorScheme.DarkPrimaryColor;

      string sLastFileName = Properties.Settings.Default.LastProjectFileName;
      if (File.Exists(sLastFileName))
      {
        LoadProject(sLastFileName);
      }
      this.Text = GenerateCaption();
    }

    private string GenerateCaption()
    {
      string sReturn = "";

      Assembly pAssembly = Assembly.GetExecutingAssembly();
      AssemblyName pAssemblyName = pAssembly.GetName();
      System.Version pVersion = pAssemblyName.Version;

      sReturn = pAssemblyName.Name + " " + pVersion.Major + "." + pVersion.Minor + "." + pVersion.Build; ;
      if (m_sProjectFileName != "")
      {
        sReturn += " - " + m_sProjectFileName;
      }
      return sReturn;
    }

    private void rbtnSave_Click(object sender, EventArgs e)
    {
      if (m_sProjectFileName == "")
      {
        rbtnSaveAs_Click(sender, e);
      }
      else
      {
        Serialize.Project pProjectSerializer = new Serialize.Project(advancedTreeView1);
        pProjectSerializer.SaveToFile(m_sProjectFileName);
      }
      this.Text = GenerateCaption();
      this.Refresh();
      Application.DoEvents();
    }

    private void rbtnSaveAs_Click(object sender, EventArgs e)
    {
      saveFileDialog1.Filter = "*.xml (Query set bestanden)|*.xml";
      saveFileDialog1.FileName = DateTime.Now.ToString("yyyyMMdd_") + "PostGIS3DVerkenner";

      saveFileDialog1.AddExtension = true;
      saveFileDialog1.AutoUpgradeEnabled = true;
      saveFileDialog1.Title = this.Text;
      DialogResult result = saveFileDialog1.ShowDialog();
      if (result == DialogResult.OK)
      {
        m_sProjectFileName = saveFileDialog1.FileName;
        Properties.Settings.Default.LastProjectFileName = m_sProjectFileName;
        Properties.Settings.Default.Save();
        Serialize.Project pProjectSerializer = new Serialize.Project(advancedTreeView1);
        pProjectSerializer.SaveToFile(m_sProjectFileName);
      }
      this.Text = GenerateCaption();
      this.Refresh();
      Application.DoEvents();
    }

    private void rbtnLoad_Click(object sender, EventArgs e)
    {
      try
      {
        openFileDialog1.Filter = "*.xml (Project bestanden)|*.xml";
        openFileDialog1.FileName = "";

        DialogResult result = openFileDialog1.ShowDialog();
        if (result == DialogResult.OK)
        {
          LoadProject(openFileDialog1.FileName);
        }
      }
      catch (Exception ex)
      {
      }
    }

    private void LoadProject(string sProjectFileName)
    {
      m_sProjectFileName = sProjectFileName;
      Properties.Settings.Default.LastProjectFileName = m_sProjectFileName;
      Properties.Settings.Default.Save();
      Serialize.Project pProjectSerializer = Serialize.Project.LoadFromFile(m_sProjectFileName);
      pProjectSerializer.Load(advancedTreeView1, renderWindowControl1);
      if (advancedTreeView1.SelectedNode != null)
      {
        this.advancedTreeView1_NodeMouseClick(this, new TreeNodeMouseClickEventArgs(advancedTreeView1.SelectedNode, MouseButtons.Left, 1, 0, 0));
      }
      this.Text = GenerateCaption();
      this.Refresh();
      Application.DoEvents();
    }

    private void renderWindowControl1_Load(object sender, EventArgs e)
    {
      vtkRenderer ren1 = renderWindowControl1.RenderWindow.GetRenderers().GetFirstRenderer();
      vtkRenderWindow renWin = renderWindowControl1.RenderWindow;

      ren1.SetBackground(1, 1, 1);
      vtkCamera camera = ren1.GetActiveCamera();
      camera.Elevation(-45);

      // Anti-alias?
      //http://vtk.1045678.n5.nabble.com/Anti-Aliasing-td5597149.html
      renWin.LineSmoothingOn();
      renWin.SetLineSmoothing(1);
      renWin.PolygonSmoothingOn();
      renWin.SetPolygonSmoothing(1);
      renWin.PointSmoothingOn();
      renWin.SetMultiSamples(1);

      // Anti-alias (slow but should always work)
      // Too slow without OpenGL...
      renWin.SetAAFrames(3);
    }

    private void Clear3DView()
    {
      if (renderWindowControl1.RenderWindow == null)
      {
        return;
      }

      try
      {
        vtkRenderer ren1 = renderWindowControl1.RenderWindow.GetRenderers().GetFirstRenderer();
        vtkRenderWindow renWin = renderWindowControl1.RenderWindow;
        try
        {
          if (ren1 != null)
          {
            vtkPropCollection p = ren1.GetViewProps();
            ren1.RemoveAllViewProps();
            ren1.RemoveAllLights();
            ren1.RemoveAllObservers();
            ren1.RemoveAllHandlersForAllEvents();
          }
        }
        catch (Exception ex)
        {

        }

        // Anti-alias?
        //http://vtk.1045678.n5.nabble.com/Anti-Aliasing-td5597149.html
        renWin.LineSmoothingOn();
        renWin.SetLineSmoothing(1);
        renWin.PolygonSmoothingOn();
        renWin.SetPolygonSmoothing(1);
        renWin.PointSmoothingOn();
        renWin.SetMultiSamples(1);

        // Anti-alias (slow but should always work)
        // Too slow without OpenGL...
        renWin.SetAAFrames(2);

        renWin.Render();
      }
      catch (Exception ex)
      {

      }
      
    }

    private void advancedTreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
    {
      if (e.Node is ConnectionTreeNode)
      {
        ConnectionTreeNode pConnectionTreeNode = e.Node as ConnectionTreeNode;
      }
      else if (e.Node is SQLTreeNode)
      {
        SQLTreeNode pSQLTreeNode = e.Node as SQLTreeNode;
        SqlContainerPanel.Controls.Clear();
        SqlContainerPanel.Controls.Add(pSQLTreeNode.SQLEditorControl);
      }
    }

    private void rbnAddConnection_Click(object sender, EventArgs e)
    {
      FrmConnection pFrmConnection = new FrmConnection();
      if (pFrmConnection.ShowDialog(this) == DialogResult.OK)
      {
        PostGISConnectionParams pPostGISConnectionParams = pFrmConnection.PostGISConnectionParams;
        ConnectionTreeNode pConnectionTreeNode = new ConnectionTreeNode(pPostGISConnectionParams);
        advancedTreeView1.Nodes.Add(pConnectionTreeNode);
        advancedTreeView1.SelectedNode = pConnectionTreeNode;
      }
    }

    private void rbnAddQuery_Click(object sender, EventArgs e)
    {
      #region Determine connection node (if present)
      ConnectionTreeNode pConnectionTreeNode = null;
      if (advancedTreeView1.SelectedNode is ConnectionTreeNode) 
      {
        pConnectionTreeNode = advancedTreeView1.SelectedNode as ConnectionTreeNode;
      }
      else if (advancedTreeView1.SelectedNode is SQLTreeNode)
      {
        pConnectionTreeNode = advancedTreeView1.SelectedNode.Parent as ConnectionTreeNode;
      }
      #endregion

      if (pConnectionTreeNode != null)
      {
        SQLTreeNode pSQLTreeNode = new SQLTreeNode(renderWindowControl1, pConnectionTreeNode.PostGISConnectionParams, "Query");
        pConnectionTreeNode.Nodes.Add(pSQLTreeNode);
        pSQLTreeNode.EnsureVisible();
        advancedTreeView1.SelectedNode = pSQLTreeNode;
        advancedTreeView1_NodeMouseClick(this, new TreeNodeMouseClickEventArgs(pSQLTreeNode, MouseButtons.Left, 1, 0, 0));
      }
    }

    private void rbnClearAll_Click(object sender, EventArgs e)
    {
      if (MaterialMessageBox.Show(this, "Alles wissen en opnieuw beginnen?", "Vraag", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
      {
        // Avoid "advancedTreeView1.Nodes.Clear()" for risc of late cleanup of resources
        advancedTreeView1.ClearWithCleanup();
        Clear3DView();
        m_sProjectFileName = "";
        this.Text = GenerateCaption();
        this.Refresh();
        Application.DoEvents();
      }
    }

    private void advancedTreeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
    {
      if (e.Label == null)
      {
        e.CancelEdit = true;
        return;
      }
      if (e.Label.Trim() == "")
      {
        e.CancelEdit = true;
        return;
      }
      if (e.Node is SQLTreeNode)
      {
        (e.Node as SQLTreeNode).Naam = e.Label;
      }

    }



  }
}
