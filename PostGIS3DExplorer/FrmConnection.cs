using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
    private Bitmap m_pImgCheck = null;
    private Bitmap m_pImgWarn = null;

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
      picExtension1.Visible = false;
      picExtension2.Visible = false;
      lblExtension1.Visible = false;
      lblExtension2.Visible = false;

      #region Load resources
      string[] res = GetType().Assembly.GetManifestResourceNames();
      if (res.GetLength(0) > 0)
      {
        Assembly pAssembly = Assembly.GetExecutingAssembly();
        AssemblyName pAssemblyName = pAssembly.GetName();
        m_pImgCheck = new System.Drawing.Bitmap(GetType().Assembly.GetManifestResourceStream(this.GetType().Namespace + ".Resources.check.png"));
        m_pImgWarn = new System.Drawing.Bitmap(GetType().Assembly.GetManifestResourceStream(this.GetType().Namespace + ".Resources.warning.png"));
      }
      #endregion

      this.DialogResult = DialogResult.None;
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
      this.Cursor = Cursors.WaitCursor;
      this.Refresh();
      Application.DoEvents();
      picExtension1.Visible = false;
      picExtension2.Visible = false;
      lblExtension1.Visible = false;
      lblExtension2.Visible = false;

      try
      {
        m_pPostGISConnectionParams.Name = txtName.Text;
        m_pPostGISConnectionParams.Host = txtLoginServer.Text;
        m_pPostGISConnectionParams.Database = txtLoginDatabase.Text;
        m_pPostGISConnectionParams.Port = txtLoginPort.Text;
        m_pPostGISConnectionParams.User_id = txtLoginName.Text;
        m_pPostGISConnectionParams.Password = txtLoginPassword.Text;

      
        try
        {
          TestConnection(m_pPostGISConnectionParams);
          this.DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
          lblLoginStatus.Visible = true;
          lblLoginStatus.Text = ex.Message;
        }
        this.Cursor = Cursors.Default;
        Application.DoEvents();
      }
      catch (Exception ex)
      {
        MaterialMessageBox.Show(this, "Fout tijdens de inlog:\n\n" + ex.Message + "\n\n(" + ex.StackTrace + ")", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

      
      try
      {
        TestConnection(pPostGISConnectionParams);

        //lblLoginStatus.Text = m_pPostGISConnectionParams.TestConnection();
        //lblLoginStatus.Text = "Succesvol verbonden";
      }
      catch (Exception ex)
      {
        lblLoginStatus.Text = ex.Message;
        lblLoginStatus.Visible = true;
        this.Cursor = Cursors.Default;
        Application.DoEvents();
        return;
      }

      this.Cursor = Cursors.Default;
      Application.DoEvents();
    }

    private void TestConnection(PostGISConnectionParams pPostGISConnectionParams)
    {
      picExtension1.Visible = false;
      picExtension2.Visible = false;
      lblExtension1.Visible = false;
      lblExtension2.Visible = false;
      picExtension1.Image = m_pImgWarn;
      picExtension2.Image = m_pImgWarn;
      lblLoginStatus.Visible = false;

      try
      {
        lblLoginStatus.Text = pPostGISConnectionParams.TestConnection();

        lblExtension1.Text = "postgis";
        lblExtension2.Text = "postgis_sfcgal";

        DataTable pExtensions = new DBHelper(pPostGISConnectionParams).PostGISExtensions();
        foreach (DataRow pDataRow in pExtensions.Rows)
        {
          if (pDataRow.Field<string>("name") == lblExtension1.Text)
          {
            picExtension1.Image = m_pImgCheck;
            lblExtension1.Text += " (" + pDataRow.Field<string>("installed_version") + ")";
          }
          else if (pDataRow.Field<string>("name") == lblExtension2.Text)
          {
            picExtension2.Image = m_pImgCheck;
            lblExtension2.Text += " (" + pDataRow.Field<string>("installed_version") + ")";
          }
        }

      }
      catch (Exception ex)
      {
        lblLoginStatus.Text = ex.Message;
        throw ex;
      }
      lblLoginStatus.Visible = true;
      picExtension1.Visible = true;
      picExtension2.Visible = true;
      lblExtension1.Visible = true;
      lblExtension2.Visible = true;

    }

  }
}
