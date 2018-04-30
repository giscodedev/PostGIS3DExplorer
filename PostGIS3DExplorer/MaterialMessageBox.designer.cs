namespace MaterialSkin.Controls
{
  partial class MaterialMessageBox
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialMessageBox));
      this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
      this.btnOK = new MaterialSkin.Controls.MaterialRaisedButton();
      this.picIcon = new System.Windows.Forms.PictureBox();
      this.lblMessage = new MaterialSkin.Controls.MaterialLabel();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnCancel.Depth = 0;
      this.btnCancel.Icon = null;
      this.btnCancel.Location = new System.Drawing.Point(349, 3);
      this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Primary = true;
      this.btnCancel.Size = new System.Drawing.Size(74, 36);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOK
      // 
      this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnOK.Depth = 0;
      this.btnOK.Icon = null;
      this.btnOK.Location = new System.Drawing.Point(269, 3);
      this.btnOK.MouseState = MaterialSkin.MouseState.HOVER;
      this.btnOK.Name = "btnOK";
      this.btnOK.Primary = true;
      this.btnOK.Size = new System.Drawing.Size(74, 36);
      this.btnOK.TabIndex = 5;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // picIcon
      // 
      this.picIcon.BackColor = System.Drawing.Color.White;
      this.picIcon.Image = ((System.Drawing.Image)(resources.GetObject("picIcon.Image")));
      this.picIcon.Location = new System.Drawing.Point(12, 78);
      this.picIcon.Name = "picIcon";
      this.picIcon.Size = new System.Drawing.Size(32, 32);
      this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.picIcon.TabIndex = 7;
      this.picIcon.TabStop = false;
      // 
      // lblMessage
      // 
      this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblMessage.BackColor = System.Drawing.Color.White;
      this.lblMessage.Depth = 0;
      this.lblMessage.Font = new System.Drawing.Font("Roboto", 11F);
      this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblMessage.Location = new System.Drawing.Point(58, 78);
      this.lblMessage.MouseState = MaterialSkin.MouseState.HOVER;
      this.lblMessage.Name = "lblMessage";
      this.lblMessage.Size = new System.Drawing.Size(360, 120);
      this.lblMessage.TabIndex = 8;
      this.lblMessage.Text = "d";
      this.lblMessage.TextChanged += new System.EventHandler(this.lblMessage_TextChanged);
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.flowLayoutPanel1.Controls.Add(this.btnCancel);
      this.flowLayoutPanel1.Controls.Add(this.btnOK);
      this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 210);
      this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(426, 46);
      this.flowLayoutPanel1.TabIndex = 9;
      // 
      // MaterialMessageBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(430, 260);
      this.Controls.Add(this.flowLayoutPanel1);
      this.Controls.Add(this.lblMessage);
      this.Controls.Add(this.picIcon);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MaterialMessageBox";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MyMessageBox";
      ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
      this.flowLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MaterialRaisedButton btnCancel;
    private MaterialRaisedButton btnOK;
    private System.Windows.Forms.PictureBox picIcon;
    private MaterialLabel lblMessage;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
  }
}