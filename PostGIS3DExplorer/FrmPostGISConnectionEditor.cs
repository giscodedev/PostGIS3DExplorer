using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace PostGIS3DExplorer
{
  public partial class FrmPostGISConnectionEditor : Form
  {
    private PostGISConnectionParams m_pPostGISConnectionParams = null;


    public FrmPostGISConnectionEditor(ref PostGISConnectionParams pPostGISConnectionParams)
    {
      InitializeComponent();
      m_pPostGISConnectionParams = pPostGISConnectionParams;
    }

    private void FrmPostGISConnection_Load(object sender, EventArgs e)
    {
      if (m_pPostGISConnectionParams != null)
      {
        txtPostGISServer.Text = m_pPostGISConnectionParams.Host;
        txtPostGISPort.Text = m_pPostGISConnectionParams.Port;
        txtPostGISDatabase.Text = m_pPostGISConnectionParams.Database;
        txtPostGISUserName.Text = m_pPostGISConnectionParams.User_id;
        txtPostGISPassword.Text = m_pPostGISConnectionParams.DecryptedPassword;
        txtPostGISSchema.Text = m_pPostGISConnectionParams.Schema;
        if (txtPostGISSchema.Text.Trim() == "")
        {
          txtPostGISSchema.Text = m_pPostGISConnectionParams.User_id;
        }
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      InputToObject();
      this.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.Close();
    }


    private void InputToObject()
    {
      try
      {
        m_pPostGISConnectionParams.Host = txtPostGISServer.Text;
        m_pPostGISConnectionParams.Port = txtPostGISPort.Text;
        m_pPostGISConnectionParams.Database = txtPostGISDatabase.Text;
        m_pPostGISConnectionParams.User_id = txtPostGISUserName.Text;
        m_pPostGISConnectionParams.Password = txtPostGISPassword.Text;
        m_pPostGISConnectionParams.Schema = txtPostGISSchema.Text;
        if (txtPostGISSchema.Text.Trim() == "")
        {
          m_pPostGISConnectionParams.Schema = m_pPostGISConnectionParams.User_id;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(this, "Er is een onverwachte fout opgetreden:\n\n" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnTestPostGISConnection_Click(object sender, EventArgs e)
    {
      try
      {
        PostGISConnectionParams pPostGISConnectionParams = new PostGISConnectionParams();
        pPostGISConnectionParams.Host = txtPostGISServer.Text;
        pPostGISConnectionParams.Port = txtPostGISPort.Text;
        pPostGISConnectionParams.Database = txtPostGISDatabase.Text;
        pPostGISConnectionParams.User_id = txtPostGISUserName.Text;
        pPostGISConnectionParams.Password = txtPostGISPassword.Text;

        string sConnect = pPostGISConnectionParams.TestConnection();



        if (sConnect != "")
        {
          MessageBox.Show(this, "Connectie geslaagd!\n\n" + sConnect, "Connectie test", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(this, "De connectie is mislukt:\n\n" + ex.Message, "Connectie test", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }



  }
}
