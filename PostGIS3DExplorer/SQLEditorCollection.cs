using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Drawing.Design;
using System.ComponentModel.Design;
using System.Collections;
using System.IO;
using System.Windows.Forms;
namespace PostGIS3DExplorer
{
  [Serializable]
  public class SQLEditorCollection //: ApplicationSettingsBase
  {
    public List<SQLEditor> SQLEditors { get; set; }

    public SQLEditorCollection()
    {
      SQLEditors = new List<SQLEditor>();
    }

    private static System.Xml.Serialization.XmlSerializer serializer;

    #region Serialize/Deserialize
    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(SQLEditorCollection));
        }
        return serializer;
      }
    }
    /// <summary>
    /// Serializes current Settings object into an XML document
    /// </summary>
    /// <returns>string XML value</returns>
    public virtual string Serialize(System.Text.Encoding encoding)
    {
      System.IO.StreamReader streamReader = null;
      System.IO.MemoryStream memoryStream = null;
      try
      {
        memoryStream = new System.IO.MemoryStream();
        System.Xml.XmlWriterSettings xmlWriterSettings = new System.Xml.XmlWriterSettings();
        xmlWriterSettings.Encoding = encoding;
        xmlWriterSettings.Indent = true;
        xmlWriterSettings.NewLineHandling = NewLineHandling.Entitize;
        System.Xml.XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
        Serializer.Serialize(xmlWriter, this);
        memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
        streamReader = new System.IO.StreamReader(memoryStream);
        return streamReader.ReadToEnd();
      }
      finally
      {
        if ((streamReader != null))
        {
          streamReader.Dispose();
        }
        if ((memoryStream != null))
        {
          memoryStream.Dispose();
        }
      }
    }

    public virtual string Serialize()
    {
      return Serialize(Encoding.UTF8);
    }

    /// <summary>
    /// Deserializes workflow markup into an Settings object
    /// </summary>
    /// <param name="xml">string workflow markup to deserialize</param>
    /// <param name="obj">Output Settings object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool Deserialize(string xml, out SQLEditorCollection obj, out System.Exception exception)
    {
      exception = null;
      obj = default(SQLEditorCollection);
      try
      {
        obj = Deserialize(xml);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool Deserialize(string xml, out SQLEditorCollection obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static SQLEditorCollection Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((SQLEditorCollection)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
      }
      finally
      {
        if ((stringReader != null))
        {
          stringReader.Dispose();
        }
      }
    }

    /// <summary>
    /// Serializes current Settings object into file
    /// </summary>
    /// <param name="fileName">full path of outupt xml file</param>
    /// <param name="exception">output Exception value if failed</param>
    /// <returns>true if can serialize and save into file; otherwise, false</returns>
    public virtual bool SaveToFile(string fileName, System.Text.Encoding encoding, out System.Exception exception)
    {
      exception = null;
      try
      {
        SaveToFile(fileName, encoding);
        return true;
      }
      catch (System.Exception e)
      {
        exception = e;
        return false;
      }
    }

    public virtual bool SaveToFile(string fileName, out System.Exception exception)
    {
      return SaveToFile(fileName, Encoding.UTF8, out exception);
    }

    public virtual void SaveToFile(string fileName)
    {
      SaveToFile(fileName, Encoding.UTF8);
    }

    public virtual void SaveToFile(string fileName, System.Text.Encoding encoding)
    {
      System.IO.StreamWriter streamWriter = null;
      try
      {
        string xmlString = Serialize(encoding);
        streamWriter = new System.IO.StreamWriter(fileName, false, Encoding.UTF8);
        streamWriter.WriteLine(xmlString);
        streamWriter.Close();
      }
      finally
      {
        if ((streamWriter != null))
        {
          streamWriter.Dispose();
        }
      }
    }

    /// <summary>
    /// Deserializes xml markup from file into an Settings object
    /// </summary>
    /// <param name="fileName">string xml file to load and deserialize</param>
    /// <param name="obj">Output Settings object</param>
    /// <param name="exception">output Exception value if deserialize failed</param>
    /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out SQLEditorCollection obj, out System.Exception exception)
    {
      exception = null;
      obj = default(SQLEditorCollection);
      try
      {
        obj = LoadFromFile(fileName, encoding);
        return true;
      }
      catch (System.Exception ex)
      {
        exception = ex;
        return false;
      }
    }

    public static bool LoadFromFile(string fileName, out SQLEditorCollection obj, out System.Exception exception)
    {
      return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
    }

    public static bool LoadFromFile(string fileName, out SQLEditorCollection obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static SQLEditorCollection LoadFromFile(string fileName)
    {
      return LoadFromFile(fileName, Encoding.UTF8);
    }

    public static SQLEditorCollection LoadFromFile(string fileName, System.Text.Encoding encoding)
    {
      System.IO.FileStream file = null;
      System.IO.StreamReader sr = null;
      try
      {
        file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
        sr = new System.IO.StreamReader(file, encoding);
        string xmlString = sr.ReadToEnd();
        sr.Close();
        file.Close();
        return Deserialize(xmlString);
      }
      finally
      {
        if ((file != null))
        {
          file.Dispose();
        }
        if ((sr != null))
        {
          sr.Dispose();
        }
      }
    }
    #endregion
  }
}
