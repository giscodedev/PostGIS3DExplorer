using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace PostGIS3DExplorer
{
  public class DBHelper
  {
    private NpgsqlConnection m_pNpgsqlConnection = null;
    private PostGISConnectionParams m_pPostGISConnectionParams = null;

    public DBHelper(PostGISConnectionParams pProjectProperties)
    {
      m_pPostGISConnectionParams = pProjectProperties;
      Connect();
    }

    ~DBHelper()
    {
      if (m_pNpgsqlConnection != null)
      {
        if (m_pNpgsqlConnection.State != ConnectionState.Closed)
        {
          m_pNpgsqlConnection.Close();
        }
      }
    }

    public NpgsqlConnection Connection
    {
      get
      {
        return m_pNpgsqlConnection;
      }
    }

    private void Connect()
    {
      #region db conncection
      if (m_pNpgsqlConnection != null)
      {
        if (m_pNpgsqlConnection.State != ConnectionState.Closed)
        {
          m_pNpgsqlConnection.Close();
        }
      }
      m_pNpgsqlConnection = m_pPostGISConnectionParams.GetConnection();
      #endregion
    }

    public DataTable GetDataTable(string sSQL, string sTableName = "", bool EnforceConstraints = false)
    {
      if (m_pNpgsqlConnection.State != ConnectionState.Open)
      {
        m_pNpgsqlConnection.Open();
      }
      return GetDataTable(new NpgsqlCommand(sSQL, m_pNpgsqlConnection), sTableName, EnforceConstraints);
    }

    public DataTable GetDataTable(NpgsqlCommand pResultCommand, string sTableName = "", bool EnforceConstraints = false)
    {
      DataTable pReturnTable = null;
      try
      {
        if (m_pNpgsqlConnection.State != ConnectionState.Open)
        {
          m_pNpgsqlConnection.Open();
        }
        using (NpgsqlDataReader pDataReader = pResultCommand.ExecuteReader())
        {
          DataSet pResultDataSet = new DataSet();
          pResultDataSet.EnforceConstraints = EnforceConstraints;
          pResultDataSet.Load(pDataReader, LoadOption.OverwriteChanges, new string[] { sTableName });
          if (pResultDataSet != null)
          {
            pReturnTable = pResultDataSet.Tables[0];
          }
        }
      }
      catch (Exception ex)
      {
        //Exception exExpand = new Exception(pResultCommand.CommandText + "\n\n" + ex.Message, ex);
        throw ex;
      }
      return pReturnTable;
    }

    public object GetSingleResultQuery(string sSQL)
    {
      if (m_pNpgsqlConnection.State != ConnectionState.Open)
      {
        m_pNpgsqlConnection.Open();
      }
      return GetSingleResultQuery(new NpgsqlCommand(sSQL, m_pNpgsqlConnection));
    }

    public object GetSingleResultQuery(NpgsqlCommand pResultCommand)
    {
      object pReturn = null;
      try
      {
        if (m_pNpgsqlConnection.State != ConnectionState.Open)
        {
          m_pNpgsqlConnection.Open();
        }
        using (NpgsqlDataReader pDataReader = pResultCommand.ExecuteReader())
        {
          if (pDataReader.Read())
          {
            pReturn = pDataReader.IsDBNull(0) ? null : pDataReader.GetValue(0);
          }
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
      return pReturn;
    }


    public int GetSingleResultNonQuery(string sSQL)
    {
      if (m_pNpgsqlConnection.State != ConnectionState.Open)
      {
        m_pNpgsqlConnection.Open();
      }
      return GetSingleResultNonQuery(new NpgsqlCommand(sSQL, m_pNpgsqlConnection));
    }

    public int GetSingleResultNonQuery(NpgsqlCommand pResultCommand)
    {
      int iReturn = -1;
      try
      {
        if (m_pNpgsqlConnection.State != ConnectionState.Open)
        {
          m_pNpgsqlConnection.Open();
        }

        iReturn = pResultCommand.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        throw ex;
      }
      return iReturn;
    }


   
  }


}
