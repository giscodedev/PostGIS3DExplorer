using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Drawing.Design;
using System.ComponentModel.Design;
using Npgsql;

namespace PostGIS3DExplorer
{
  [Serializable]
  public class PostGISConnectionParams
  {
    private string m_sName = "Nieuwe verbinding";
    private string m_sHost = "localhost";
    private string m_sPort = "5432";
    private string m_sDatabase = "postgis";
    private string m_sSchema = "wozbag";
    private string m_sUser_id = "postgres";
    private string m_sPassword = "";

    [UserScopedSetting()]
    [BrowsableAttribute(false)]
    [Description("PostGIS connectie string.")]
    [CategoryAttribute("PostGIS connectie string")]
    public string PostGIS_connectie_string
    {
      get
      {
        //m_sConnection = "Server=" + sHost + ";Port=" + sPort + ";User Id=" + sUserName + ";Password=" + sPassword + ";Database=" + sDatabase + ";SyncNotification=true;";

        StringBuilder sConnectionString = new StringBuilder();

        sConnectionString.Append("Server=");
        sConnectionString.Append(m_sHost);
        sConnectionString.Append(";");

        sConnectionString.Append("Port=");
        sConnectionString.Append(m_sPort);
        sConnectionString.Append(";");

        sConnectionString.Append("User Id=");
        sConnectionString.Append(m_sUser_id);
        sConnectionString.Append(";");

        sConnectionString.Append("Password=");
        sConnectionString.Append(this.DecryptedPassword);
        sConnectionString.Append(";");

        sConnectionString.Append("Database=");
        sConnectionString.Append(m_sDatabase);
        sConnectionString.Append(";");

        //sConnectionString.Append("SyncNotification=true;");
        sConnectionString.Append(";CommandTimeout=0;");

        return sConnectionString.ToString();
      }
    }

    [UserScopedSetting()]
    [SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Xml)]
    [DefaultSettingValue("True")]
    [BrowsableAttribute(false)]
    [Description("Connection name.")]
    [CategoryAttribute("Connection name")]
    public string Name
    {
      get
      {
        return m_sName;
      }
      set
      {
        m_sName = value;
      }
    }

    public override string ToString()
    {
      return this.Name;
    }

    [UserScopedSetting()]
    [SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Xml)]
    [DefaultSettingValue("True")]
    [BrowsableAttribute(false)]
    [Description("PostGIS server.")]
    [CategoryAttribute("PostGIS connectie")]
    public string Host
    {
      get
      {
        return m_sHost;
      }
      set
      {
        m_sHost = value;
      }
    }

    [UserScopedSetting()]
    [SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Xml)]
    [DefaultSettingValue("True")]
    [BrowsableAttribute(false)]
    [Description("PostGIS service.")]
    [CategoryAttribute("PostGIS service")]
    public string Database
    {
      get
      {
        return m_sDatabase;
      }
      set
      {
        m_sDatabase = value;
      }
    }

    [UserScopedSetting()]
    [SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Xml)]
    [DefaultSettingValue("True")]
    [BrowsableAttribute(false)]
    [Description("PostGIS port.")]
    [CategoryAttribute("PostGIS connectie")]
    public string Port
    {
      get
      {
        return m_sPort;
      }
      set
      {
        m_sPort = value;
      }
    }

    [UserScopedSetting()]
    [SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Xml)]
    [DefaultSettingValue("True")]
    [BrowsableAttribute(false)]
    [Description("PostGIS schema.")]
    [CategoryAttribute("PostGIS schema")]
    public string Schema
    {
      get
      {
        if (m_sSchema == "")
        {
          m_sSchema = "bag";
        }
        return m_sSchema;
      }
      set
      {
        m_sSchema = value;
      }
    }


    [UserScopedSetting()]
    [SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Xml)]
    [DefaultSettingValue("True")]
    [BrowsableAttribute(false)]
    [Description("PostGIS loginnaam.")]
    [CategoryAttribute("PostGIS connectie")]
    public string User_id
    {
      get
      {
        return m_sUser_id;
      }
      set
      {
        m_sUser_id = value;
      }
    }

    [UserScopedSetting()]
    [SettingsSerializeAs(System.Configuration.SettingsSerializeAs.Xml)]
    [DefaultSettingValue("True")]
    [BrowsableAttribute(false)]
    [Description("PostGIS wachtwoord.")]
    [CategoryAttribute("PostGIS connectie")]
    [System.Xml.Serialization.XmlElementAttribute("Password")]
    public string _Password
    {
      get
      {
        return m_sPassword;
      }
      set
      {
        m_sPassword = value;
      }
    }

    [System.Xml.Serialization.XmlIgnore]
    public string Password
    {
      get
      {
        return m_sPassword;
      }
      set
      {
        //m_sPassword = BAGEXTRACT.Crypt.EncryptString(value, "geheim");
        m_sPassword = value;
      }
    }

    public string DecryptedPassword
    {
      get
      {
        return m_sPassword;
        //return BAGEXTRACT.Crypt.DecryptString(m_sPassword, "geheim");
      }
    }

    public string TestConnection()
    {
      string sReturn = "";
      try
      {
        NpgsqlConnection pNpgsqlConnection = this.GetConnection();
        if (pNpgsqlConnection.State == ConnectionState.Open)
        {
          NpgsqlCommand NpgsqlCommand = new NpgsqlCommand("select version()", pNpgsqlConnection);
          using (NpgsqlDataReader pNpgsqlDataReader = NpgsqlCommand.ExecuteReader())
          {
            // Always call Read before accessing data.
            if (pNpgsqlDataReader.Read())
            {
              sReturn = pNpgsqlDataReader.GetString(0);
            }
          }
          pNpgsqlConnection.Close();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
      finally
      {

      }
      return sReturn;
    }

    public List<string[]> w2g_projectproperties()
    {
      List<string[]> pSchemaList = new List<string[]>();

      //string sSQL = @"select 
      //                  table_schema,
      //                  table_name 
      //                from 
      //                  information_schema.tables 
      //                where
      //                  table_name = 'pand_model'
      //                order by 
      //                  table_schema,
      //                  table_name;";
      string sSQL = @"select 
                        schema,
                        gebiedsnaam,
                        percelen,
                        luchtfoto
                      from 
                        w2g_projectproperties
                      order by 
                        schema;";
      try
      {
        NpgsqlConnection pNpgsqlConnection = this.GetConnection();
        if (pNpgsqlConnection.State == ConnectionState.Open)
        {
          NpgsqlCommand NpgsqlCommand = new NpgsqlCommand(sSQL, pNpgsqlConnection);
          using (NpgsqlDataReader pNpgsqlDataReader = NpgsqlCommand.ExecuteReader())
          {
            // Always call Read before accessing data.
            while (pNpgsqlDataReader.Read())
            {
              string[] pItems = new string[4];
              pItems[0] = pNpgsqlDataReader.GetString(0);
              pItems[1] = pNpgsqlDataReader.GetString(1);
              pItems[2] = pNpgsqlDataReader.GetString(2);
              pItems[3] = pNpgsqlDataReader.GetString(3);

              pSchemaList.Add(pItems);
            }
          }
          pNpgsqlConnection.Close();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
      finally
      {

      }

      return pSchemaList;
    }


    public NpgsqlConnection GetConnection(bool bOpen = true)
    {
      NpgsqlConnection pNpgsqlConnection = null;
      try
      {
        pNpgsqlConnection = new NpgsqlConnection(this.PostGIS_connectie_string);
        if (bOpen)
        {
          pNpgsqlConnection.Open();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
      finally
      {

      }
      return pNpgsqlConnection;
    }

  }
}
