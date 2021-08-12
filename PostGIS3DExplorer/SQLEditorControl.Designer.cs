﻿namespace PostGIS3DExplorer
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
      this.rbtnTransparancy = new System.Windows.Forms.RibbonUpDown();
      this.rbtnPointSize = new System.Windows.Forms.RibbonUpDown();
      this.prgMain = new MaterialSkin.Controls.MaterialProgressBar();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
      ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // fastColoredTextBox1
      // 
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
      this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(1187, 60);
      this.fastColoredTextBox1.BackBrush = null;
      this.fastColoredTextBox1.CharHeight = 20;
      this.fastColoredTextBox1.CharWidth = 12;
      this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.fastColoredTextBox1.Font = new System.Drawing.Font("Lucida Console", 10F);
      this.fastColoredTextBox1.IsReplaceMode = false;
      this.fastColoredTextBox1.LineInterval = 1;
      this.fastColoredTextBox1.Location = new System.Drawing.Point(4, 139);
      this.fastColoredTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.fastColoredTextBox1.Name = "fastColoredTextBox1";
      this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
      this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
      this.fastColoredTextBox1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox1.ServiceColors")));
      this.fastColoredTextBox1.Size = new System.Drawing.Size(1377, 446);
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
      this.ribbon1.Size = new System.Drawing.Size(1385, 134);
      this.ribbon1.TabIndex = 85;
      this.ribbon1.Tabs.Add(this.rbnTabMain);
      this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 2, 20, 0);
      this.ribbon1.Text = "ribbon1";
      this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
      // 
      // rbnTabMain
      // 
      this.rbnTabMain.Panels.Add(this.rbnPanelQuery);
      this.rbnTabMain.Panels.Add(this.ribbonPanel1);
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
      this.rbnPanelQuery.Items.Add(this.rbtnTransparancy);
      this.rbnPanelQuery.Items.Add(this.rbtnPointSize);
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
      // rbtnTransparancy
      // 
      this.rbtnTransparancy.Text = "Transparantie %";
      this.rbtnTransparancy.TextBoxText = "100";
      this.rbtnTransparancy.TextBoxWidth = 50;
      this.rbtnTransparancy.Value = "100";
      this.rbtnTransparancy.UpButtonClicked += new System.Windows.Forms.MouseEventHandler(this.rbtnTransparancy_UpButtonClicked);
      this.rbtnTransparancy.DownButtonClicked += new System.Windows.Forms.MouseEventHandler(this.rbtnTransparancy_DownButtonClicked);
      // 
      // rbtnPointSize
      // 
      this.rbtnPointSize.Text = "Grootte";
      this.rbtnPointSize.TextBoxText = "6";
      this.rbtnPointSize.TextBoxWidth = 50;
      this.rbtnPointSize.Value = "6";
      this.rbtnPointSize.UpButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDown1_UpButtonClicked);
      this.rbtnPointSize.DownButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDown1_DownButtonClicked);
      // 
      // prgMain
      // 
      this.prgMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.prgMain.Depth = 0;
      this.prgMain.Location = new System.Drawing.Point(4, 600);
      this.prgMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.prgMain.MouseState = MaterialSkin.MouseState.HOVER;
      this.prgMain.Name = "prgMain";
      this.prgMain.Size = new System.Drawing.Size(1377, 5);
      this.prgMain.TabIndex = 86;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.prgMain, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.ribbon1);
      this.tableLayoutPanel1.Controls.Add(this.fastColoredTextBox1, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1385, 610);
      this.tableLayoutPanel1.TabIndex = 87;
      // 
      // ribbonPanel1
      // 
      this.ribbonPanel1.Text = "ribbonPanel1";
      // 
      // SQLEditorControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "SQLEditorControl";
      this.Size = new System.Drawing.Size(1385, 610);
      this.Load += new System.EventHandler(this.SQLEditorControl_Load);
      ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
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
    internal System.Windows.Forms.RibbonPanel rbnPanelQuery;
    private System.Windows.Forms.RibbonUpDown rbtnTransparancy;
    private MaterialSkin.Controls.MaterialProgressBar prgMain;
    private System.Windows.Forms.RibbonUpDown rbtnPointSize;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.RibbonPanel ribbonPanel1;
  }
}
