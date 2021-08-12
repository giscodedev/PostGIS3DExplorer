﻿namespace PostGIS3DExplorer
{
  partial class FrmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      this.advancedTreeView1 = new MaterialSkin.Controls.AdvancedTreeView();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.renderWindowControl1 = new Kitware.VTK.RenderWindowControl();
      this.SqlContainerPanel = new System.Windows.Forms.Panel();
      this.ribbon1 = new System.Windows.Forms.Ribbon();
      this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
      this.panelProject = new System.Windows.Forms.RibbonPanel();
      this.rbtnSave = new System.Windows.Forms.RibbonButton();
      this.rbtnSaveAs = new System.Windows.Forms.RibbonButton();
      this.rbtnLoad = new System.Windows.Forms.RibbonButton();
      this.panelQuery = new System.Windows.Forms.RibbonPanel();
      this.rbtnExecuteQuery = new System.Windows.Forms.RibbonButton();
      this.rbtnRemoveQuery = new System.Windows.Forms.RibbonButton();
      this.rbtnRemoveAllQueries = new System.Windows.Forms.RibbonButton();
      this.rbtnAddConnection = new System.Windows.Forms.RibbonButton();
      this.rbtnAddQuery = new System.Windows.Forms.RibbonButton();
      this.panel3D = new System.Windows.Forms.RibbonPanel();
      this.rbtnZoomFull = new System.Windows.Forms.RibbonButton();
      this.panelDemo = new System.Windows.Forms.RibbonPanel();
      this.rbtnDemoData = new System.Windows.Forms.RibbonButton();
      this.rbtnDemoProject = new System.Windows.Forms.RibbonButton();
      this.rbtnLoadDemoProject1 = new System.Windows.Forms.RibbonButton();
      this.rbtnLoadDemoProject2 = new System.Windows.Forms.RibbonButton();
      this.panelUI = new System.Windows.Forms.RibbonPanel();
      this.rbtnNL = new System.Windows.Forms.RibbonButton();
      this.rbtnEN = new System.Windows.Forms.RibbonButton();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // advancedTreeView1
      // 
      this.advancedTreeView1.AllowDrop = true;
      this.advancedTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.advancedTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.advancedTreeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
      this.advancedTreeView1.ImageIndex = 0;
      this.advancedTreeView1.ImageList = this.imageList1;
      this.advancedTreeView1.LabelEdit = true;
      this.advancedTreeView1.Location = new System.Drawing.Point(3, 138);
      this.advancedTreeView1.Name = "advancedTreeView1";
      this.tableLayoutPanel1.SetRowSpan(this.advancedTreeView1, 2);
      this.advancedTreeView1.SelectedFocusColor = System.Drawing.Color.Empty;
      this.advancedTreeView1.SelectedImageIndex = 0;
      this.advancedTreeView1.SelectedLostFocusColor = System.Drawing.Color.Empty;
      this.advancedTreeView1.Size = new System.Drawing.Size(594, 1205);
      this.advancedTreeView1.TabIndex = 0;
      this.advancedTreeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.advancedTreeView1_AfterLabelEdit);
      this.advancedTreeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.advancedTreeView1_NodeMouseClick);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "sql");
      this.imageList1.Images.SetKeyName(1, "connection");
      // 
      // renderWindowControl1
      // 
      this.renderWindowControl1.AddTestActors = false;
      this.renderWindowControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.renderWindowControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.renderWindowControl1.Location = new System.Drawing.Point(603, 138);
      this.renderWindowControl1.Name = "renderWindowControl1";
      this.renderWindowControl1.Size = new System.Drawing.Size(1372, 755);
      this.renderWindowControl1.TabIndex = 82;
      this.renderWindowControl1.TestText = null;
      this.renderWindowControl1.Load += new System.EventHandler(this.renderWindowControl1_Load);
      // 
      // SqlContainerPanel
      // 
      this.SqlContainerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.SqlContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SqlContainerPanel.Location = new System.Drawing.Point(603, 899);
      this.SqlContainerPanel.Name = "SqlContainerPanel";
      this.SqlContainerPanel.Size = new System.Drawing.Size(1372, 444);
      this.SqlContainerPanel.TabIndex = 83;
      // 
      // ribbon1
      // 
      this.ribbon1.CaptionBarVisible = false;
      this.tableLayoutPanel1.SetColumnSpan(this.ribbon1, 2);
      this.ribbon1.Font = new System.Drawing.Font("Roboto", 9F);
      this.ribbon1.Location = new System.Drawing.Point(0, 0);
      this.ribbon1.Margin = new System.Windows.Forms.Padding(0);
      this.ribbon1.Minimized = false;
      this.ribbon1.Name = "ribbon1";
      // 
      // 
      // 
      this.ribbon1.OrbDropDown.BorderRoundness = 8;
      this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
      this.ribbon1.OrbDropDown.Name = "";
      this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
      this.ribbon1.OrbDropDown.TabIndex = 0;
      this.ribbon1.OrbImage = null;
      this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
      this.ribbon1.OrbVisible = false;
      // 
      // 
      // 
      this.ribbon1.QuickAcessToolbar.Visible = false;
      this.ribbon1.RibbonTabFont = new System.Drawing.Font("Roboto", 10F);
      this.ribbon1.Size = new System.Drawing.Size(1978, 135);
      this.ribbon1.TabIndex = 83;
      this.ribbon1.Tabs.Add(this.ribbonTab1);
      this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
      this.ribbon1.Text = "ribbon1";
      this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
      // 
      // ribbonTab1
      // 
      this.ribbonTab1.Panels.Add(this.panelProject);
      this.ribbonTab1.Panels.Add(this.panelQuery);
      this.ribbonTab1.Panels.Add(this.panel3D);
      this.ribbonTab1.Panels.Add(this.panelDemo);
      this.ribbonTab1.Panels.Add(this.panelUI);
      this.ribbonTab1.Text = "Start";
      // 
      // panelProject
      // 
      this.panelProject.Items.Add(this.rbtnSave);
      this.panelProject.Items.Add(this.rbtnSaveAs);
      this.panelProject.Items.Add(this.rbtnLoad);
      this.panelProject.Text = "Project";
      // 
      // rbtnSave
      // 
      this.rbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("rbtnSave.Image")));
      this.rbtnSave.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbtnSave.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnSave.SmallImage")));
      this.rbtnSave.Text = "Opslaan";
      this.rbtnSave.Click += new System.EventHandler(this.rbtnSave_Click);
      // 
      // rbtnSaveAs
      // 
      this.rbtnSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("rbtnSaveAs.Image")));
      this.rbtnSaveAs.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbtnSaveAs.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnSaveAs.SmallImage")));
      this.rbtnSaveAs.Text = "Opslaan als";
      this.rbtnSaveAs.Click += new System.EventHandler(this.rbtnSaveAs_Click);
      // 
      // rbtnLoad
      // 
      this.rbtnLoad.Image = ((System.Drawing.Image)(resources.GetObject("rbtnLoad.Image")));
      this.rbtnLoad.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbtnLoad.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnLoad.SmallImage")));
      this.rbtnLoad.Text = "Laden";
      this.rbtnLoad.Click += new System.EventHandler(this.rbtnLoad_Click);
      // 
      // panelQuery
      // 
      this.panelQuery.Items.Add(this.rbtnExecuteQuery);
      this.panelQuery.Items.Add(this.rbtnRemoveQuery);
      this.panelQuery.Items.Add(this.rbtnRemoveAllQueries);
      this.panelQuery.Items.Add(this.rbtnAddConnection);
      this.panelQuery.Items.Add(this.rbtnAddQuery);
      this.panelQuery.Text = "Database";
      // 
      // rbtnExecuteQuery
      // 
      this.rbtnExecuteQuery.Image = ((System.Drawing.Image)(resources.GetObject("rbtnExecuteQuery.Image")));
      this.rbtnExecuteQuery.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbtnExecuteQuery.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnExecuteQuery.SmallImage")));
      this.rbtnExecuteQuery.Text = "Uitvoeren";
      this.rbtnExecuteQuery.Click += new System.EventHandler(this.rbtnExecuteQuery_Click);
      // 
      // rbtnRemoveQuery
      // 
      this.rbtnRemoveQuery.Image = ((System.Drawing.Image)(resources.GetObject("rbtnRemoveQuery.Image")));
      this.rbtnRemoveQuery.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbtnRemoveQuery.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnRemoveQuery.SmallImage")));
      this.rbtnRemoveQuery.Text = "Verwijderen";
      this.rbtnRemoveQuery.Click += new System.EventHandler(this.rbtnRemoveQuery_Click);
      // 
      // rbtnRemoveAllQueries
      // 
      this.rbtnRemoveAllQueries.Image = ((System.Drawing.Image)(resources.GetObject("rbtnRemoveAllQueries.Image")));
      this.rbtnRemoveAllQueries.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbtnRemoveAllQueries.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnRemoveAllQueries.SmallImage")));
      this.rbtnRemoveAllQueries.Text = "Alles wissen";
      this.rbtnRemoveAllQueries.Click += new System.EventHandler(this.RemoveAllQueries_Click);
      // 
      // rbtnAddConnection
      // 
      this.rbtnAddConnection.Image = ((System.Drawing.Image)(resources.GetObject("rbtnAddConnection.Image")));
      this.rbtnAddConnection.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbtnAddConnection.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnAddConnection.SmallImage")));
      this.rbtnAddConnection.Text = "+ Connectie";
      this.rbtnAddConnection.ToolTip = "Nieuwe connectie toevoegen";
      this.rbtnAddConnection.Click += new System.EventHandler(this.rbnAddConnection_Click);
      // 
      // rbtnAddQuery
      // 
      this.rbtnAddQuery.Image = ((System.Drawing.Image)(resources.GetObject("rbtnAddQuery.Image")));
      this.rbtnAddQuery.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbtnAddQuery.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnAddQuery.SmallImage")));
      this.rbtnAddQuery.Text = "+ Vraag";
      this.rbtnAddQuery.Click += new System.EventHandler(this.rbnAddQuery_Click);
      // 
      // panel3D
      // 
      this.panel3D.Items.Add(this.rbtnZoomFull);
      this.panel3D.Text = "3D View";
      // 
      // rbtnZoomFull
      // 
      this.rbtnZoomFull.Image = ((System.Drawing.Image)(resources.GetObject("rbtnZoomFull.Image")));
      this.rbtnZoomFull.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbtnZoomFull.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnZoomFull.SmallImage")));
      this.rbtnZoomFull.Text = "Uitzoomen";
      this.rbtnZoomFull.Click += new System.EventHandler(this.rbtnZoomFull_Click);
      // 
      // panelDemo
      // 
      this.panelDemo.Items.Add(this.rbtnDemoData);
      this.panelDemo.Items.Add(this.rbtnDemoProject);
      this.panelDemo.Text = "Demo";
      // 
      // rbtnDemoData
      // 
      this.rbtnDemoData.Enabled = false;
      this.rbtnDemoData.Image = ((System.Drawing.Image)(resources.GetObject("rbtnDemoData.Image")));
      this.rbtnDemoData.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbtnDemoData.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnDemoData.SmallImage")));
      this.rbtnDemoData.Text = "Demo data";
      this.rbtnDemoData.ToolTip = "Demo data laden";
      this.rbtnDemoData.Click += new System.EventHandler(this.rbtnDemoData_Click);
      // 
      // rbtnDemoProject
      // 
      this.rbtnDemoProject.DropDownItems.Add(this.rbtnLoadDemoProject1);
      this.rbtnDemoProject.DropDownItems.Add(this.rbtnLoadDemoProject2);
      this.rbtnDemoProject.Image = ((System.Drawing.Image)(resources.GetObject("rbtnDemoProject.Image")));
      this.rbtnDemoProject.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbtnDemoProject.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnDemoProject.SmallImage")));
      this.rbtnDemoProject.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
      this.rbtnDemoProject.Text = "Demo project";
      // 
      // rbtnLoadDemoProject1
      // 
      this.rbtnLoadDemoProject1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.rbtnLoadDemoProject1.Image = ((System.Drawing.Image)(resources.GetObject("rbtnLoadDemoProject1.Image")));
      this.rbtnLoadDemoProject1.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnLoadDemoProject1.SmallImage")));
      this.rbtnLoadDemoProject1.Text = "Demo project 1 - basisvormen";
      this.rbtnLoadDemoProject1.Click += new System.EventHandler(this.rbtnLoadDemoProject1_Click);
      // 
      // rbtnLoadDemoProject2
      // 
      this.rbtnLoadDemoProject2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
      this.rbtnLoadDemoProject2.Image = ((System.Drawing.Image)(resources.GetObject("rbtnLoadDemoProject2.Image")));
      this.rbtnLoadDemoProject2.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnLoadDemoProject2.SmallImage")));
      this.rbtnLoadDemoProject2.Text = "Demo project 2 - AHN en BAG";
      this.rbtnLoadDemoProject2.Click += new System.EventHandler(this.rbtnLoadDemoProject2_Click);
      // 
      // panelUI
      // 
      this.panelUI.Items.Add(this.rbtnNL);
      this.panelUI.Items.Add(this.rbtnEN);
      this.panelUI.Text = "UI";
      // 
      // rbtnNL
      // 
      this.rbtnNL.Image = ((System.Drawing.Image)(resources.GetObject("rbtnNL.Image")));
      this.rbtnNL.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
      this.rbtnNL.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnNL.SmallImage")));
      this.rbtnNL.Text = "Nederlands";
      this.rbtnNL.Click += new System.EventHandler(this.rbtnSwitchLanguage_Click);
      // 
      // rbtnEN
      // 
      this.rbtnEN.Image = ((System.Drawing.Image)(resources.GetObject("rbtnEN.Image")));
      this.rbtnEN.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
      this.rbtnEN.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnEN.SmallImage")));
      this.rbtnEN.Text = "English";
      this.rbtnEN.Click += new System.EventHandler(this.rbtnSwitchLanguage_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.SqlContainerPanel, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.renderWindowControl1, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.advancedTreeView1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.ribbon1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 450F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1978, 1346);
      this.tableLayoutPanel1.TabIndex = 86;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.ClientSize = new System.Drawing.Size(1978, 1346);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
      this.Name = "FrmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PostGIS 3D Verkenner";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.Ribbon ribbon1;
    private System.Windows.Forms.RibbonTab ribbonTab1;
    private System.Windows.Forms.RibbonPanel panelQuery;
    private System.Windows.Forms.RibbonButton rbtnAddConnection;
    private MaterialSkin.Controls.AdvancedTreeView advancedTreeView1;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.Panel SqlContainerPanel;
    private System.Windows.Forms.RibbonButton rbtnRemoveAllQueries;
    private System.Windows.Forms.RibbonButton rbtnAddQuery;
    private System.Windows.Forms.RibbonPanel panelProject;
    private System.Windows.Forms.RibbonButton rbtnSave;
    private System.Windows.Forms.RibbonButton rbtnLoad;
    private System.Windows.Forms.RibbonButton rbtnSaveAs;
    private System.Windows.Forms.RibbonPanel panelDemo;
    private System.Windows.Forms.RibbonButton rbtnDemoData;
    private System.Windows.Forms.RibbonButton rbtnDemoProject;
    private System.Windows.Forms.RibbonButton rbtnLoadDemoProject1;
    private System.Windows.Forms.RibbonButton rbtnLoadDemoProject2;
    private System.Windows.Forms.RibbonPanel panel3D;
    private System.Windows.Forms.RibbonButton rbtnZoomFull;
    private System.Windows.Forms.RibbonButton rbtnExecuteQuery;
    private System.Windows.Forms.RibbonButton rbtnRemoveQuery;
    private Kitware.VTK.RenderWindowControl renderWindowControl1;
    private System.Windows.Forms.RibbonPanel panelUI;
    private System.Windows.Forms.RibbonButton rbtnNL;
    private System.Windows.Forms.RibbonButton rbtnEN;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
  }
}

