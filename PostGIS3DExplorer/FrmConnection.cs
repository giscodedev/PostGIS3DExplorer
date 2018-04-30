using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PostGIS3DExplorer
{
  public partial class FrmConnection : MaterialForm
  {
    private PostGISConnectionParams m_pPostGISConnectionParams = new PostGISConnectionParams();

    public PostGISConnectionParams PostGISConnectionParams
    {
      get
      {
        return m_pPostGISConnectionParams;
      }
      set
      {
        m_pPostGISConnectionParams = value;
        txtName.Text = m_pPostGISConnectionParams.Name;
        txtLoginServer.Text = m_pPostGISConnectionParams.Host;
        txtLoginDatabase.Text = m_pPostGISConnectionParams.Database;
        txtLoginPort.Text = m_pPostGISConnectionParams.Port;
        txtLoginName.Text = m_pPostGISConnectionParams.User_id;
        txtLoginPassword.Text = m_pPostGISConnectionParams.Password;
      }
    }

    public FrmConnection()
    {
      InitializeComponent();
    }

    private void FrmConnection_Load(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.None;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      this.Refresh();
      Application.DoEvents();

      try
      {
        m_pPostGISConnectionParams.Name = txtName.Text;
        m_pPostGISConnectionParams.Host = txtLoginServer.Text;
        m_pPostGISConnectionParams.Database = txtLoginDatabase.Text;
        m_pPostGISConnectionParams.Port = txtLoginPort.Text;
        m_pPostGISConnectionParams.User_id = txtLoginName.Text;
        m_pPostGISConnectionParams.Password = txtLoginPassword.Text;

        lblLoginStatus.Visible = true;
        try
        {
          lblLoginStatus.Text = m_pPostGISConnectionParams.TestConnection();
          lblLoginStatus.Text = "Succesvol verbonden";
        }
        catch (Exception ex)
        {
          lblLoginStatus.Text = ex.Message;
          this.Cursor = Cursors.Default;
          Application.DoEvents();
          return;
        }

        //Program.DBHelper = new DBHelper(m_pPostGISConnectionParams);
        this.DialogResult = DialogResult.OK;
      }
      catch (Exception ex)
      {
        MessageBox.Show(this, "Fout tijdens de inlog:\n\n" + ex.Message + "\n\n(" + ex.StackTrace + ")", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      this.Cursor = Cursors.Default;
      Application.DoEvents();
    }

    private void btnLoginTest_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      this.Refresh();
      Application.DoEvents();

      PostGISConnectionParams pPostGISConnectionParams = new PostGISConnectionParams();
      pPostGISConnectionParams.Host = txtLoginServer.Text;
      pPostGISConnectionParams.Database = txtLoginDatabase.Text;
      pPostGISConnectionParams.Port = txtLoginPort.Text;
      pPostGISConnectionParams.User_id = txtLoginName.Text;
      pPostGISConnectionParams.Password = txtLoginPassword.Text;

      lblLoginStatus.Visible = true;
      try
      {
        lblLoginStatus.Text = pPostGISConnectionParams.TestConnection();
        lblLoginStatus.Text = "Succesvol verbonden";
      }
      catch (Exception ex)
      {
        lblLoginStatus.Text = ex.Message;
      }

      this.Cursor = Cursors.Default;
      Application.DoEvents();



    }

  }
}
