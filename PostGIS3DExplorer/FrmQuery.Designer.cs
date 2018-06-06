namespace PostGIS3DExplorer
{
  partial class FrmQuery
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
      this.btnCancel = new MaterialSkin.Controls.MaterialRaisedButton();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnCancel.AutoSize = true;
      this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnCancel.Depth = 0;
      this.btnCancel.Icon = null;
      this.btnCancel.Location = new System.Drawing.Point(174, 104);
      this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Primary = true;
      this.btnCancel.Size = new System.Drawing.Size(100, 36);
      this.btnCancel.TabIndex = 0;
      this.btnCancel.Text = "Annuleren";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // FrmQuery
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(444, 190);
      this.Controls.Add(this.btnCancel);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmQuery";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.Sizable = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Gegevens ophalen...";
      this.Load += new System.EventHandler(this.FrmQuery_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MaterialSkin.Controls.MaterialRaisedButton btnCancel;
  }
}