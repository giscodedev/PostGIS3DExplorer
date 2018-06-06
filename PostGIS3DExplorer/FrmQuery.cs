using MaterialSkin.Controls;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostGIS3DExplorer
{
  public partial class FrmQuery : MaterialForm
  {
    public FrmQuery()
    {
      InitializeComponent();
    }

    public PostGISConnectionParams PostGISConnectionParams
    {
      get;
      set;
    }
    public string SQL
    {
      get;
      set;
    }
    public DataTable DataTable { get; set;}
    private DBHelper mDBHelper;

    private CancellationTokenSource mCancellationTokenSource;

    private async void FrmQuery_Load(object sender, EventArgs e)
    {
      this.Text = Program.resourceManager.GetString("MESSAGE_QUERY_RUNNING", Program.CultureInfo);
      btnCancel.Text = Program.resourceManager.GetString("CANCEL", Program.CultureInfo);

      try
      {
        this.DataTable = await GetDataTableAsync();
      }
      catch (Exception ex)
      {
        string sCode = "";
        try
        {
          sCode = (string)ex.Data["Code"];
        } catch (Exception exData){}

        if (sCode != "57014")
        {
          MaterialMessageBox.Show(this, Program.resourceManager.GetString("MESSAGE_QUERY_ERROR", Program.CultureInfo)  +":\n\n" + ex.Message, Program.resourceManager.GetString("QUERY_ERROR_TITLE", Program.CultureInfo), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private async Task<DataTable> GetDataTableAsync()
    {
      DataTable pDataTable = null;

      mCancellationTokenSource = new CancellationTokenSource();

      mDBHelper = new DBHelper(this.PostGISConnectionParams);
      using (NpgsqlConnection pNpgsqlConnection = mDBHelper.Connection)
      {
        if (pNpgsqlConnection.State != ConnectionState.Open)
        {
          pNpgsqlConnection.Open();
        }

        NpgsqlCommand pResultCommand = new NpgsqlCommand(this.SQL, pNpgsqlConnection);
        using (DbDataReader pDataReader = await pResultCommand.ExecuteReaderAsync(CommandBehavior.SequentialAccess, mCancellationTokenSource.Token))
        {
          DataSet pResultDataSet = new DataSet();
          pResultDataSet.EnforceConstraints = false;
          pResultDataSet.Load(pDataReader, LoadOption.OverwriteChanges, new string[] { "tablename" });
          if (pResultDataSet != null)
          {
            pDataTable = pResultDataSet.Tables[0];
          }
        }
      }

      mDBHelper.Connection.Close();
      mDBHelper = null;

      return pDataTable;
    }

    /// <summary>
    /// Cancel the asynchronously running Command reader
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnCancel_Click(object sender, EventArgs e)
    {
      if (mCancellationTokenSource != null)
      {
        mCancellationTokenSource.Cancel();
        this.DialogResult = DialogResult.Cancel;
      }
    }

  }
}
