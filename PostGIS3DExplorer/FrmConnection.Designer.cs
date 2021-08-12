namespace PostGIS3DExplorer
{
  partial class FrmConnection
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnection));
      this.txtLoginPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
      this.txtLoginName = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.lblUserName = new MaterialSkin.Controls.MaterialLabel();
      this.txtLoginDatabase = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.txtLoginPort = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.txtLoginServer = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.lblDatabase = new MaterialSkin.Controls.MaterialLabel();
      this.lblPort = new MaterialSkin.Controls.MaterialLabel();
      this.lblServer = new MaterialSkin.Controls.MaterialLabel();
      this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
      this.lblLoginStatus = new MaterialSkin.Controls.MaterialLabel();
      this.btnLoginTest = new MaterialSkin.Controls.MaterialFlatButton();
      this.lblName = new MaterialSkin.Controls.MaterialLabel();
      this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
      this.lblExtension1 = new MaterialSkin.Controls.MaterialLabel();
      this.lblExtension2 = new MaterialSkin.Controls.MaterialLabel();
      this.picExtension1 = new System.Windows.Forms.PictureBox();
      this.picExtension2 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.picExtension1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picExtension2)).BeginInit();
      this.SuspendLayout();
      // 
      // txtLoginPassword
      // 
      this.txtLoginPassword.Depth = 0;
      this.txtLoginPassword.Hint = "";
      this.txtLoginPassword.Location = new System.Drawing.Point(159, 162);
      this.txtLoginPassword.MaxLength = 32767;
      this.txtLoginPassword.MouseState = MaterialSkin.MouseState.HOVER;
      this.txtLoginPassword.Name = "txtLoginPassword";
      this.txtLoginPassword.PasswordChar = '\0';
      this.txtLoginPassword.SelectedText = "";
      this.txtLoginPassword.SelectionLength = 0;
      this.txtLoginPassword.SelectionStart = 0;
      this.txtLoginPassword.Size = new System.Drawing.Size(225, 23);
      this.txtLoginPassword.TabIndex = 7;
      this.txtLoginPassword.TabStop = false;
      this.txtLoginPassword.Text = "postgres";
      this.txtLoginPassword.UseSystemPasswordChar = true;
      // 
      // lblPassword
      // 
      this.lblPassword.AutoSize = true;
      this.lblPassword.Depth = 0;
      this.lblPassword.Font = new System.Drawing.Font("Roboto", 11F);
      this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblPassword.Location = new System.Drawing.Point(26, 162);
      this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(93, 19);
      this.lblPassword.TabIndex = 6;
      this.lblPassword.Text = "Wachtwoord";
      // 
      // txtLoginName
      // 
      this.txtLoginName.Depth = 0;
      this.txtLoginName.Hint = "";
      this.txtLoginName.Location = new System.Drawing.Point(159, 129);
      this.txtLoginName.MaxLength = 32767;
      this.txtLoginName.MouseState = MaterialSkin.MouseState.HOVER;
      this.txtLoginName.Name = "txtLoginName";
      this.txtLoginName.PasswordChar = '\0';
      this.txtLoginName.SelectedText = "";
      this.txtLoginName.SelectionLength = 0;
      this.txtLoginName.SelectionStart = 0;
      this.txtLoginName.Size = new System.Drawing.Size(225, 23);
      this.txtLoginName.TabIndex = 5;
      this.txtLoginName.TabStop = false;
      this.txtLoginName.Text = "postgres";
      this.txtLoginName.UseSystemPasswordChar = false;
      // 
      // lblUserName
      // 
      this.lblUserName.AutoSize = true;
      this.lblUserName.Depth = 0;
      this.lblUserName.Font = new System.Drawing.Font("Roboto", 11F);
      this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblUserName.Location = new System.Drawing.Point(26, 129);
      this.lblUserName.MouseState = MaterialSkin.MouseState.HOVER;
      this.lblUserName.Name = "lblUserName";
      this.lblUserName.Size = new System.Drawing.Size(110, 19);
      this.lblUserName.TabIndex = 4;
      this.lblUserName.Text = "Gebruikernaam";
      // 
      // txtLoginDatabase
      // 
      this.txtLoginDatabase.Depth = 0;
      this.txtLoginDatabase.Hint = "";
      this.txtLoginDatabase.Location = new System.Drawing.Point(159, 261);
      this.txtLoginDatabase.MaxLength = 32767;
      this.txtLoginDatabase.MouseState = MaterialSkin.MouseState.HOVER;
      this.txtLoginDatabase.Name = "txtLoginDatabase";
      this.txtLoginDatabase.PasswordChar = '\0';
      this.txtLoginDatabase.SelectedText = "";
      this.txtLoginDatabase.SelectionLength = 0;
      this.txtLoginDatabase.SelectionStart = 0;
      this.txtLoginDatabase.Size = new System.Drawing.Size(225, 23);
      this.txtLoginDatabase.TabIndex = 14;
      this.txtLoginDatabase.TabStop = false;
      this.txtLoginDatabase.Text = "postgis";
      this.txtLoginDatabase.UseSystemPasswordChar = false;
      // 
      // txtLoginPort
      // 
      this.txtLoginPort.Depth = 0;
      this.txtLoginPort.Hint = "";
      this.txtLoginPort.Location = new System.Drawing.Point(159, 228);
      this.txtLoginPort.MaxLength = 32767;
      this.txtLoginPort.MouseState = MaterialSkin.MouseState.HOVER;
      this.txtLoginPort.Name = "txtLoginPort";
      this.txtLoginPort.PasswordChar = '\0';
      this.txtLoginPort.SelectedText = "";
      this.txtLoginPort.SelectionLength = 0;
      this.txtLoginPort.SelectionStart = 0;
      this.txtLoginPort.Size = new System.Drawing.Size(50, 23);
      this.txtLoginPort.TabIndex = 13;
      this.txtLoginPort.TabStop = false;
      this.txtLoginPort.Text = "5432";
      this.txtLoginPort.UseSystemPasswordChar = false;
      // 
      // txtLoginServer
      // 
      this.txtLoginServer.Depth = 0;
      this.txtLoginServer.Hint = "";
      this.txtLoginServer.Location = new System.Drawing.Point(159, 195);
      this.txtLoginServer.MaxLength = 32767;
      this.txtLoginServer.MouseState = MaterialSkin.MouseState.HOVER;
      this.txtLoginServer.Name = "txtLoginServer";
      this.txtLoginServer.PasswordChar = '\0';
      this.txtLoginServer.SelectedText = "";
      this.txtLoginServer.SelectionLength = 0;
      this.txtLoginServer.SelectionStart = 0;
      this.txtLoginServer.Size = new System.Drawing.Size(225, 23);
      this.txtLoginServer.TabIndex = 12;
      this.txtLoginServer.TabStop = false;
      this.txtLoginServer.Text = "localhost";
      this.txtLoginServer.UseSystemPasswordChar = false;
      // 
      // lblDatabase
      // 
      this.lblDatabase.AutoSize = true;
      this.lblDatabase.Depth = 0;
      this.lblDatabase.Font = new System.Drawing.Font("Roboto", 11F);
      this.lblDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblDatabase.Location = new System.Drawing.Point(26, 261);
      this.lblDatabase.MouseState = MaterialSkin.MouseState.HOVER;
      this.lblDatabase.Name = "lblDatabase";
      this.lblDatabase.Size = new System.Drawing.Size(72, 19);
      this.lblDatabase.TabIndex = 10;
      this.lblDatabase.Text = "Database";
      // 
      // lblPort
      // 
      this.lblPort.AutoSize = true;
      this.lblPort.Depth = 0;
      this.lblPort.Font = new System.Drawing.Font("Roboto", 11F);
      this.lblPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblPort.Location = new System.Drawing.Point(26, 228);
      this.lblPort.MouseState = MaterialSkin.MouseState.HOVER;
      this.lblPort.Name = "lblPort";
      this.lblPort.Size = new System.Drawing.Size(46, 19);
      this.lblPort.TabIndex = 9;
      this.lblPort.Text = "Poort";
      // 
      // lblServer
      // 
      this.lblServer.AutoSize = true;
      this.lblServer.Depth = 0;
      this.lblServer.Font = new System.Drawing.Font("Roboto", 11F);
      this.lblServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblServer.Location = new System.Drawing.Point(26, 195);
      this.lblServer.MouseState = MaterialSkin.MouseState.HOVER;
      this.lblServer.Name = "lblServer";
      this.lblServer.Size = new System.Drawing.Size(51, 19);
      this.lblServer.TabIndex = 8;
      this.lblServer.Text = "Server";
      // 
      // btnLogin
      // 
      this.btnLogin.AutoSize = true;
      this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnLogin.Depth = 0;
      this.btnLogin.Icon = null;
      this.btnLogin.Location = new System.Drawing.Point(289, 307);
      this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Primary = true;
      this.btnLogin.Size = new System.Drawing.Size(95, 36);
      this.btnLogin.TabIndex = 3;
      this.btnLogin.Text = "Verbinden";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // lblLoginStatus
      // 
      this.lblLoginStatus.Depth = 0;
      this.lblLoginStatus.Font = new System.Drawing.Font("Roboto", 11F);
      this.lblLoginStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblLoginStatus.Location = new System.Drawing.Point(22, 363);
      this.lblLoginStatus.MouseState = MaterialSkin.MouseState.HOVER;
      this.lblLoginStatus.Name = "lblLoginStatus";
      this.lblLoginStatus.Size = new System.Drawing.Size(358, 30);
      this.lblLoginStatus.TabIndex = 11;
      this.lblLoginStatus.Text = "...";
      this.lblLoginStatus.Visible = false;
      // 
      // btnLoginTest
      // 
      this.btnLoginTest.AutoSize = true;
      this.btnLoginTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnLoginTest.Depth = 0;
      this.btnLoginTest.Icon = null;
      this.btnLoginTest.Location = new System.Drawing.Point(20, 307);
      this.btnLoginTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
      this.btnLoginTest.MouseState = MaterialSkin.MouseState.HOVER;
      this.btnLoginTest.Name = "btnLoginTest";
      this.btnLoginTest.Primary = false;
      this.btnLoginTest.Size = new System.Drawing.Size(132, 36);
      this.btnLoginTest.TabIndex = 7;
      this.btnLoginTest.Text = "Test connectie";
      this.btnLoginTest.UseVisualStyleBackColor = true;
      this.btnLoginTest.Click += new System.EventHandler(this.btnLoginTest_Click);
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Depth = 0;
      this.lblName.Font = new System.Drawing.Font("Roboto", 11F);
      this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblName.Location = new System.Drawing.Point(26, 96);
      this.lblName.MouseState = MaterialSkin.MouseState.HOVER;
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(118, 19);
      this.lblName.TabIndex = 4;
      this.lblName.Text = "Connectie naam";
      // 
      // txtName
      // 
      this.txtName.Depth = 0;
      this.txtName.Hint = "";
      this.txtName.Location = new System.Drawing.Point(159, 96);
      this.txtName.MaxLength = 32767;
      this.txtName.MouseState = MaterialSkin.MouseState.HOVER;
      this.txtName.Name = "txtName";
      this.txtName.PasswordChar = '\0';
      this.txtName.SelectedText = "";
      this.txtName.SelectionLength = 0;
      this.txtName.SelectionStart = 0;
      this.txtName.Size = new System.Drawing.Size(225, 23);
      this.txtName.TabIndex = 5;
      this.txtName.TabStop = false;
      this.txtName.Text = "Postgis #1";
      this.txtName.UseSystemPasswordChar = false;
      // 
      // lblExtension1
      // 
      this.lblExtension1.Depth = 0;
      this.lblExtension1.Font = new System.Drawing.Font("Roboto", 11F);
      this.lblExtension1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblExtension1.Location = new System.Drawing.Point(51, 391);
      this.lblExtension1.MouseState = MaterialSkin.MouseState.HOVER;
      this.lblExtension1.Name = "lblExtension1";
      this.lblExtension1.Size = new System.Drawing.Size(358, 24);
      this.lblExtension1.TabIndex = 11;
      this.lblExtension1.Text = "...";
      this.lblExtension1.Visible = false;
      // 
      // lblExtension2
      // 
      this.lblExtension2.Depth = 0;
      this.lblExtension2.Font = new System.Drawing.Font("Roboto", 11F);
      this.lblExtension2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.lblExtension2.Location = new System.Drawing.Point(51, 421);
      this.lblExtension2.MouseState = MaterialSkin.MouseState.HOVER;
      this.lblExtension2.Name = "lblExtension2";
      this.lblExtension2.Size = new System.Drawing.Size(358, 24);
      this.lblExtension2.TabIndex = 11;
      this.lblExtension2.Text = "...";
      this.lblExtension2.Visible = false;
      // 
      // picExtension1
      // 
      this.picExtension1.Image = ((System.Drawing.Image)(resources.GetObject("picExtension1.Image")));
      this.picExtension1.Location = new System.Drawing.Point(20, 391);
      this.picExtension1.Margin = new System.Windows.Forms.Padding(0);
      this.picExtension1.Name = "picExtension1";
      this.picExtension1.Size = new System.Drawing.Size(24, 24);
      this.picExtension1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.picExtension1.TabIndex = 15;
      this.picExtension1.TabStop = false;
      this.picExtension1.Visible = false;
      // 
      // picExtension2
      // 
      this.picExtension2.Image = ((System.Drawing.Image)(resources.GetObject("picExtension2.Image")));
      this.picExtension2.Location = new System.Drawing.Point(20, 421);
      this.picExtension2.Margin = new System.Windows.Forms.Padding(0);
      this.picExtension2.Name = "picExtension2";
      this.picExtension2.Size = new System.Drawing.Size(24, 24);
      this.picExtension2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.picExtension2.TabIndex = 15;
      this.picExtension2.TabStop = false;
      this.picExtension2.Visible = false;
      // 
      // FrmConnection
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(421, 467);
      this.Controls.Add(this.picExtension2);
      this.Controls.Add(this.picExtension1);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.txtLoginDatabase);
      this.Controls.Add(this.lblExtension2);
      this.Controls.Add(this.lblExtension1);
      this.Controls.Add(this.lblLoginStatus);
      this.Controls.Add(this.txtLoginPassword);
      this.Controls.Add(this.btnLoginTest);
      this.Controls.Add(this.txtLoginPort);
      this.Controls.Add(this.txtLoginServer);
      this.Controls.Add(this.lblDatabase);
      this.Controls.Add(this.lblPassword);
      this.Controls.Add(this.lblPort);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.txtLoginName);
      this.Controls.Add(this.lblName);
      this.Controls.Add(this.lblServer);
      this.Controls.Add(this.lblUserName);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmConnection";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "PostgreSQL connectie";
      this.Load += new System.EventHandler(this.FrmConnection_Load);
      ((System.ComponentModel.ISupportInitialize)(this.picExtension1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picExtension2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MaterialSkin.Controls.MaterialSingleLineTextField txtLoginPassword;
    private MaterialSkin.Controls.MaterialLabel lblPassword;
    private MaterialSkin.Controls.MaterialSingleLineTextField txtLoginName;
    private MaterialSkin.Controls.MaterialLabel lblUserName;
    private MaterialSkin.Controls.MaterialSingleLineTextField txtLoginDatabase;
    private MaterialSkin.Controls.MaterialSingleLineTextField txtLoginPort;
    private MaterialSkin.Controls.MaterialSingleLineTextField txtLoginServer;
    private MaterialSkin.Controls.MaterialLabel lblDatabase;
    private MaterialSkin.Controls.MaterialLabel lblPort;
    private MaterialSkin.Controls.MaterialLabel lblServer;
    private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
    private MaterialSkin.Controls.MaterialLabel lblLoginStatus;
    private MaterialSkin.Controls.MaterialFlatButton btnLoginTest;
    private MaterialSkin.Controls.MaterialLabel lblName;
    private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
    private MaterialSkin.Controls.MaterialLabel lblExtension1;
    private MaterialSkin.Controls.MaterialLabel lblExtension2;
    private System.Windows.Forms.PictureBox picExtension1;
    private System.Windows.Forms.PictureBox picExtension2;
  }
}