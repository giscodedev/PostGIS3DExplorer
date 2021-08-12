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
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnCancel.AutoSize = true;
      this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnCancel.Location = new System.Drawing.Point(169, 77);
      this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(113, 35);
      this.btnCancel.TabIndex = 0;
      this.btnCancel.Text = "Annuleren";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // FrmQuery
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.ClientSize = new System.Drawing.Size(465, 137);
      this.Controls.Add(this.btnCancel);
      this.Font = new System.Drawing.Font("Roboto", 10F);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmQuery";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Gegevens ophalen...";
      this.Load += new System.EventHandler(this.FrmQuery_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCancel;
  }
}