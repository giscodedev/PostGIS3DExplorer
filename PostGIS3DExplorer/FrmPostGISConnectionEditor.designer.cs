namespace PostGIS3DExplorer
{
  partial class FrmPostGISConnectionEditor
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPostGISConnectionEditor));
      this.txtPostGISPassword = new System.Windows.Forms.TextBox();
      this.txtPostGISUserName = new System.Windows.Forms.TextBox();
      this.txtPostGISDatabase = new System.Windows.Forms.TextBox();
      this.txtPostGISPort = new System.Windows.Forms.TextBox();
      this.txtPostGISServer = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.btnTestPostGISConnection = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtPostGISSchema = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // txtPostGISPassword
      // 
      this.txtPostGISPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.txtPostGISPassword.Location = new System.Drawing.Point(142, 109);
      this.txtPostGISPassword.Name = "txtPostGISPassword";
      this.txtPostGISPassword.Size = new System.Drawing.Size(155, 20);
      this.txtPostGISPassword.TabIndex = 35;
      this.txtPostGISPassword.UseSystemPasswordChar = true;
      // 
      // txtPostGISUserName
      // 
      this.txtPostGISUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.txtPostGISUserName.Location = new System.Drawing.Point(142, 84);
      this.txtPostGISUserName.Name = "txtPostGISUserName";
      this.txtPostGISUserName.Size = new System.Drawing.Size(155, 20);
      this.txtPostGISUserName.TabIndex = 34;
      // 
      // txtPostGISDatabase
      // 
      this.txtPostGISDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.txtPostGISDatabase.Location = new System.Drawing.Point(142, 32);
      this.txtPostGISDatabase.Name = "txtPostGISDatabase";
      this.txtPostGISDatabase.Size = new System.Drawing.Size(155, 20);
      this.txtPostGISDatabase.TabIndex = 32;
      // 
      // txtPostGISPort
      // 
      this.txtPostGISPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.txtPostGISPort.Location = new System.Drawing.Point(142, 58);
      this.txtPostGISPort.Name = "txtPostGISPort";
      this.txtPostGISPort.Size = new System.Drawing.Size(155, 20);
      this.txtPostGISPort.TabIndex = 33;
      // 
      // txtPostGISServer
      // 
      this.txtPostGISServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.txtPostGISServer.Location = new System.Drawing.Point(142, 6);
      this.txtPostGISServer.Name = "txtPostGISServer";
      this.txtPostGISServer.Size = new System.Drawing.Size(155, 20);
      this.txtPostGISServer.TabIndex = 30;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.label7.Location = new System.Drawing.Point(45, 112);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(68, 13);
      this.label7.TabIndex = 29;
      this.label7.Text = "Wachtwoord";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.label8.Location = new System.Drawing.Point(45, 87);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(84, 13);
      this.label8.TabIndex = 28;
      this.label8.Text = "Gebruikersnaam";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.label10.Location = new System.Drawing.Point(45, 61);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(32, 13);
      this.label10.TabIndex = 26;
      this.label10.Text = "Poort";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.label11.Location = new System.Drawing.Point(45, 9);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(38, 13);
      this.label11.TabIndex = 25;
      this.label11.Text = "Server";
      // 
      // btnTestPostGISConnection
      // 
      this.btnTestPostGISConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.btnTestPostGISConnection.Location = new System.Drawing.Point(48, 173);
      this.btnTestPostGISConnection.Name = "btnTestPostGISConnection";
      this.btnTestPostGISConnection.Size = new System.Drawing.Size(112, 23);
      this.btnTestPostGISConnection.TabIndex = 37;
      this.btnTestPostGISConnection.Text = "Test connectie";
      this.btnTestPostGISConnection.UseVisualStyleBackColor = true;
      this.btnTestPostGISConnection.Click += new System.EventHandler(this.btnTestPostGISConnection_Click);
      // 
      // btnOK
      // 
      this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.btnOK.Location = new System.Drawing.Point(185, 173);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(112, 23);
      this.btnOK.TabIndex = 38;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(7, 7);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(32, 32);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 39;
      this.pictureBox1.TabStop = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.label2.Location = new System.Drawing.Point(45, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 40;
      this.label2.Text = "Database";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.label3.Location = new System.Drawing.Point(45, 138);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 13);
      this.label3.TabIndex = 29;
      this.label3.Text = "Schema";
      // 
      // txtPostGISSchema
      // 
      this.txtPostGISSchema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.txtPostGISSchema.Location = new System.Drawing.Point(142, 135);
      this.txtPostGISSchema.Name = "txtPostGISSchema";
      this.txtPostGISSchema.Size = new System.Drawing.Size(155, 20);
      this.txtPostGISSchema.TabIndex = 36;
      // 
      // FrmBECPostGISConnectionEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(318, 209);
      this.Controls.Add(this.txtPostGISSchema);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.txtPostGISDatabase);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.btnTestPostGISConnection);
      this.Controls.Add(this.txtPostGISPassword);
      this.Controls.Add(this.txtPostGISUserName);
      this.Controls.Add(this.txtPostGISPort);
      this.Controls.Add(this.txtPostGISServer);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label11);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "FrmBECPostGISConnectionEditor";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "PostGIS connectie";
      this.Load += new System.EventHandler(this.FrmPostGISConnection_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtPostGISPassword;
    private System.Windows.Forms.TextBox txtPostGISUserName;
    private System.Windows.Forms.TextBox txtPostGISDatabase;
    private System.Windows.Forms.TextBox txtPostGISPort;
    private System.Windows.Forms.TextBox txtPostGISServer;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Button btnTestPostGISConnection;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtPostGISSchema;
  }
}