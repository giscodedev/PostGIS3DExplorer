namespace PostGIS3DExplorer
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
      this.split3D_sql = new System.Windows.Forms.SplitContainer();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.renderWindowControl1 = new Kitware.VTK.RenderWindowControl();
      this.SqlContainerPanel = new System.Windows.Forms.Panel();
      this.ribbon1 = new System.Windows.Forms.Ribbon();
      this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
      this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
      this.rbtnSave = new System.Windows.Forms.RibbonButton();
      this.rbtnSaveAs = new System.Windows.Forms.RibbonButton();
      this.rbtnLoad = new System.Windows.Forms.RibbonButton();
      this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
      this.rbnClearAll = new System.Windows.Forms.RibbonButton();
      this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
      this.rbnAddConnection = new System.Windows.Forms.RibbonButton();
      this.rbnAddQuery = new System.Windows.Forms.RibbonButton();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.mainControlsPanel = new System.Windows.Forms.Panel();
      this.advancedTreeView1 = new MaterialSkin.Controls.AdvancedTreeView();
      ((System.ComponentModel.ISupportInitialize)(this.split3D_sql)).BeginInit();
      this.split3D_sql.Panel1.SuspendLayout();
      this.split3D_sql.Panel2.SuspendLayout();
      this.split3D_sql.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.mainControlsPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // split3D_sql
      // 
      this.split3D_sql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.split3D_sql.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.split3D_sql.Location = new System.Drawing.Point(3, 110);
      this.split3D_sql.Margin = new System.Windows.Forms.Padding(0);
      this.split3D_sql.Name = "split3D_sql";
      // 
      // split3D_sql.Panel1
      // 
      this.split3D_sql.Panel1.Controls.Add(this.advancedTreeView1);
      // 
      // split3D_sql.Panel2
      // 
      this.split3D_sql.Panel2.Controls.Add(this.splitContainer1);
      this.split3D_sql.Size = new System.Drawing.Size(1423, 843);
      this.split3D_sql.SplitterDistance = 340;
      this.split3D_sql.TabIndex = 84;
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "connection");
      this.imageList1.Images.SetKeyName(1, "sql_old");
      this.imageList1.Images.SetKeyName(2, "sql");
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.renderWindowControl1);
      this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.SqlContainerPanel);
      this.splitContainer1.Size = new System.Drawing.Size(1079, 843);
      this.splitContainer1.SplitterDistance = 510;
      this.splitContainer1.TabIndex = 82;
      // 
      // renderWindowControl1
      // 
      this.renderWindowControl1.AddTestActors = false;
      this.renderWindowControl1.BackColor = System.Drawing.Color.White;
      this.renderWindowControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.renderWindowControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.renderWindowControl1.ForeColor = System.Drawing.Color.Black;
      this.renderWindowControl1.Location = new System.Drawing.Point(0, 0);
      this.renderWindowControl1.Name = "renderWindowControl1";
      this.renderWindowControl1.Size = new System.Drawing.Size(1079, 510);
      this.renderWindowControl1.TabIndex = 81;
      this.renderWindowControl1.TestText = null;
      this.renderWindowControl1.Load += new System.EventHandler(this.renderWindowControl1_Load);
      // 
      // SqlContainerPanel
      // 
      this.SqlContainerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.SqlContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.SqlContainerPanel.Location = new System.Drawing.Point(0, 0);
      this.SqlContainerPanel.Name = "SqlContainerPanel";
      this.SqlContainerPanel.Size = new System.Drawing.Size(1079, 329);
      this.SqlContainerPanel.TabIndex = 83;
      // 
      // ribbon1
      // 
      this.ribbon1.CaptionBarVisible = false;
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
      this.ribbon1.Size = new System.Drawing.Size(1426, 110);
      this.ribbon1.TabIndex = 83;
      this.ribbon1.Tabs.Add(this.ribbonTab1);
      this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
      this.ribbon1.Text = "ribbon1";
      this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
      // 
      // ribbonTab1
      // 
      this.ribbonTab1.Panels.Add(this.ribbonPanel2);
      this.ribbonTab1.Panels.Add(this.ribbonPanel1);
      this.ribbonTab1.Text = "Start";
      // 
      // ribbonPanel2
      // 
      this.ribbonPanel2.Items.Add(this.rbtnSave);
      this.ribbonPanel2.Items.Add(this.rbtnSaveAs);
      this.ribbonPanel2.Items.Add(this.rbtnLoad);
      this.ribbonPanel2.Items.Add(this.ribbonSeparator1);
      this.ribbonPanel2.Items.Add(this.rbnClearAll);
      this.ribbonPanel2.Text = "Project";
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
      // rbnClearAll
      // 
      this.rbnClearAll.Image = ((System.Drawing.Image)(resources.GetObject("rbnClearAll.Image")));
      this.rbnClearAll.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbnClearAll.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnClearAll.SmallImage")));
      this.rbnClearAll.Text = "Alles wissen";
      this.rbnClearAll.Click += new System.EventHandler(this.rbnClearAll_Click);
      // 
      // ribbonPanel1
      // 
      this.ribbonPanel1.Items.Add(this.rbnAddConnection);
      this.ribbonPanel1.Items.Add(this.rbnAddQuery);
      this.ribbonPanel1.Text = "Algemeen";
      // 
      // rbnAddConnection
      // 
      this.rbnAddConnection.Image = ((System.Drawing.Image)(resources.GetObject("rbnAddConnection.Image")));
      this.rbnAddConnection.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbnAddConnection.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnAddConnection.SmallImage")));
      this.rbnAddConnection.Text = "+ Connectie";
      this.rbnAddConnection.ToolTip = "Nieuwe connectie toevoegen";
      this.rbnAddConnection.Click += new System.EventHandler(this.rbnAddConnection_Click);
      // 
      // rbnAddQuery
      // 
      this.rbnAddQuery.Image = ((System.Drawing.Image)(resources.GetObject("rbnAddQuery.Image")));
      this.rbnAddQuery.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbnAddQuery.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbnAddQuery.SmallImage")));
      this.rbnAddQuery.Text = "+ Query";
      this.rbnAddQuery.Click += new System.EventHandler(this.rbnAddQuery_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // mainControlsPanel
      // 
      this.mainControlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mainControlsPanel.Controls.Add(this.ribbon1);
      this.mainControlsPanel.Controls.Add(this.split3D_sql);
      this.mainControlsPanel.Location = new System.Drawing.Point(6, 65);
      this.mainControlsPanel.Name = "mainControlsPanel";
      this.mainControlsPanel.Size = new System.Drawing.Size(1426, 953);
      this.mainControlsPanel.TabIndex = 85;
      // 
      // advancedTreeView1
      // 
      this.advancedTreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.advancedTreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.advancedTreeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
      this.advancedTreeView1.ImageIndex = 0;
      this.advancedTreeView1.ImageList = this.imageList1;
      this.advancedTreeView1.LabelEdit = true;
      this.advancedTreeView1.Location = new System.Drawing.Point(0, 0);
      this.advancedTreeView1.Name = "advancedTreeView1";
      this.advancedTreeView1.SelectedFocusColor = System.Drawing.Color.Empty;
      this.advancedTreeView1.SelectedImageIndex = 0;
      this.advancedTreeView1.SelectedLostFocusColor = System.Drawing.Color.Empty;
      this.advancedTreeView1.Size = new System.Drawing.Size(340, 843);
      this.advancedTreeView1.TabIndex = 0;
      this.advancedTreeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.advancedTreeView1_AfterLabelEdit);
      this.advancedTreeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.advancedTreeView1_NodeMouseClick);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1440, 1024);
      this.Controls.Add(this.mainControlsPanel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PostGIS 3D Verkenner";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.split3D_sql.Panel1.ResumeLayout(false);
      this.split3D_sql.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.split3D_sql)).EndInit();
      this.split3D_sql.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.mainControlsPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.SplitContainer splitContainer1;
    private Kitware.VTK.RenderWindowControl renderWindowControl1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.SplitContainer split3D_sql;
    private System.Windows.Forms.Ribbon ribbon1;
    private System.Windows.Forms.RibbonTab ribbonTab1;
    private System.Windows.Forms.RibbonPanel ribbonPanel1;
    private System.Windows.Forms.RibbonButton rbnAddConnection;
    private MaterialSkin.Controls.AdvancedTreeView advancedTreeView1;
    private System.Windows.Forms.ImageList imageList1;
    private System.Windows.Forms.Panel mainControlsPanel;
    private System.Windows.Forms.Panel SqlContainerPanel;
    private System.Windows.Forms.RibbonButton rbnClearAll;
    private System.Windows.Forms.RibbonButton rbnAddQuery;
    private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
    private System.Windows.Forms.RibbonPanel ribbonPanel2;
    private System.Windows.Forms.RibbonButton rbtnSave;
    private System.Windows.Forms.RibbonButton rbtnLoad;
    private System.Windows.Forms.RibbonButton rbtnSaveAs;
  }
}

