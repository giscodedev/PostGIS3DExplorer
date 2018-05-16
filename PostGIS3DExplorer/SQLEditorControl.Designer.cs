namespace PostGIS3DExplorer
{
  partial class SQLEditorControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLEditorControl));
      this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.ribbon1 = new System.Windows.Forms.Ribbon();
      this.rbnTabMain = new System.Windows.Forms.RibbonTab();
      this.rbnPanelQuery = new System.Windows.Forms.RibbonPanel();
      this.rbtnExecute = new System.Windows.Forms.RibbonButton();
      this.rbtnDelete = new System.Windows.Forms.RibbonButton();
      this.rbtnFillColor = new System.Windows.Forms.RibbonColorChooser();
      this.rbtnOutline = new System.Windows.Forms.RibbonCheckBox();
      this.ribbonUpDown2 = new System.Windows.Forms.RibbonUpDown();
      this.panel1 = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // fastColoredTextBox1
      // 
      this.fastColoredTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
      this.fastColoredTextBox1.AutoIndent = false;
      this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(893, 45);
      this.fastColoredTextBox1.BackBrush = null;
      this.fastColoredTextBox1.CharHeight = 15;
      this.fastColoredTextBox1.CharWidth = 9;
      this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.fastColoredTextBox1.Font = new System.Drawing.Font("Lucida Console", 11.25F);
      this.fastColoredTextBox1.IsReplaceMode = false;
      this.fastColoredTextBox1.LineInterval = 1;
      this.fastColoredTextBox1.Location = new System.Drawing.Point(0, 113);
      this.fastColoredTextBox1.Name = "fastColoredTextBox1";
      this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
      this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
      this.fastColoredTextBox1.Size = new System.Drawing.Size(660, 186);
      this.fastColoredTextBox1.TabIndex = 81;
      this.fastColoredTextBox1.TabLength = 2;
      this.fastColoredTextBox1.Text = "select st_astext( \r\n  (st_dump((st_extrude( st_expand(st_geomfromtext(\'point(0 0)" +
    "\', 28992), 5, 5), 0, 0, 10)))).geom\r\n)";
      this.fastColoredTextBox1.Zoom = 100;
      // 
      // ribbon1
      // 
      this.ribbon1.CaptionBarVisible = false;
      this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
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
      this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
      this.ribbon1.Size = new System.Drawing.Size(660, 110);
      this.ribbon1.TabIndex = 85;
      this.ribbon1.Tabs.Add(this.rbnTabMain);
      this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
      this.ribbon1.Text = "ribbon1";
      this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
      // 
      // rbnTabMain
      // 
      this.rbnTabMain.Panels.Add(this.rbnPanelQuery);
      this.rbnTabMain.Text = "Query 1";
      // 
      // rbnPanelQuery
      // 
      this.rbnPanelQuery.ButtonMoreEnabled = false;
      this.rbnPanelQuery.ButtonMoreVisible = false;
      this.rbnPanelQuery.Items.Add(this.rbtnExecute);
      this.rbnPanelQuery.Items.Add(this.rbtnDelete);
      this.rbnPanelQuery.Items.Add(this.rbtnFillColor);
      this.rbnPanelQuery.Items.Add(this.rbtnOutline);
      this.rbnPanelQuery.Items.Add(this.ribbonUpDown2);
      this.rbnPanelQuery.Text = "Query";
      // 
      // rbtnExecute
      // 
      this.rbtnExecute.Image = ((System.Drawing.Image)(resources.GetObject("rbtnExecute.Image")));
      this.rbtnExecute.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbtnExecute.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnExecute.SmallImage")));
      this.rbtnExecute.Text = "Uitvoeren";
      this.rbtnExecute.Click += new System.EventHandler(this.btnExecute_Click);
      // 
      // rbtnDelete
      // 
      this.rbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("rbtnDelete.Image")));
      this.rbtnDelete.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbtnDelete.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnDelete.SmallImage")));
      this.rbtnDelete.Text = "Weghalen";
      this.rbtnDelete.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // rbtnFillColor
      // 
      this.rbtnFillColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.rbtnFillColor.Image = ((System.Drawing.Image)(resources.GetObject("rbtnFillColor.Image")));
      this.rbtnFillColor.MinimumSize = new System.Drawing.Size(95, 0);
      this.rbtnFillColor.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnFillColor.SmallImage")));
      this.rbtnFillColor.Text = "Vulkleur";
      this.rbtnFillColor.Click += new System.EventHandler(this.rbtnFillColor_Click);
      // 
      // rbtnOutline
      // 
      this.rbtnOutline.Checked = true;
      this.rbtnOutline.Text = "Omlijning";
      this.rbtnOutline.CheckBoxCheckChanged += new System.EventHandler(this.rbtnOutline_CheckedChanged);
      // 
      // ribbonUpDown2
      // 
      this.ribbonUpDown2.Text = "Transparantie";
      this.ribbonUpDown2.TextBoxText = "";
      this.ribbonUpDown2.TextBoxWidth = 50;
      this.ribbonUpDown2.Value = "1";
      this.ribbonUpDown2.Visible = false;
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.Controls.Add(this.ribbon1);
      this.panel1.Controls.Add(this.fastColoredTextBox1);
      this.panel1.Location = new System.Drawing.Point(2, -27);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(660, 299);
      this.panel1.TabIndex = 86;
      // 
      // SQLEditorControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.panel1);
      this.Name = "SQLEditorControl";
      this.Size = new System.Drawing.Size(665, 275);
      ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    internal FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.RibbonButton rbtnExecute;
    private System.Windows.Forms.RibbonButton rbtnDelete;
    private System.Windows.Forms.RibbonColorChooser rbtnFillColor;
    private System.Windows.Forms.RibbonCheckBox rbtnOutline;
    private System.Windows.Forms.Ribbon ribbon1;
    internal System.Windows.Forms.RibbonTab rbnTabMain;
    private System.Windows.Forms.Panel panel1;
    internal System.Windows.Forms.RibbonPanel rbnPanelQuery;
    private System.Windows.Forms.RibbonUpDown ribbonUpDown2;
  }
}
