using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostGIS3DExplorer;
using Kitware.VTK;
using System.Xml;
using System.IO;
using System.ComponentModel;
using MaterialSkin.Controls;

namespace System.Windows.Forms
{
  [Serializable]
  public class SQLTreeNode : TreeNode
  {

    private SQLEditorControl m_pSQLEditorControl = null;
    private PostGISConnectionParams m_pPostGISConnectionParams = new PostGISConnectionParams();

    public SQLEditorControl SQLEditorControl
    {
      get { return m_pSQLEditorControl; }
    }

    public PostGISConnectionParams PostGISConnectionParams
    {
      get { return m_pPostGISConnectionParams; }
      set { m_pPostGISConnectionParams = value; }
    }

    public SQLTreeNode(RenderWindowControl pRenderWindowControl, PostGISConnectionParams pPostGISConnectionParams, string QueryName) : base(QueryName)
    {
      m_pPostGISConnectionParams = pPostGISConnectionParams;
      //this.ImageKey = "sql";
      //this.SelectedImageKey = "sql";
      this.ImageIndex = 0;
      this.SelectedImageIndex = 0;
      m_pSQLEditorControl = new SQLEditorControl();
      m_pSQLEditorControl.Dock = DockStyle.Fill;
      m_pSQLEditorControl.rbnPanelQuery.Text = QueryName;
      m_pSQLEditorControl.PostGISConnectionParams = m_pPostGISConnectionParams;
      m_pSQLEditorControl.RenderWindowControl = pRenderWindowControl;

      TreeNodeContextMenu cms = new TreeNodeContextMenu();
      cms.Opening += ContextMenuStripOnOpening;
      cms.OnItemClickStart += ContextMenuStripOnItemClickStart;
      this.ContextMenuStrip = cms;
    }

    public new SQLTreeNode Clone()
    {
      SQLTreeNode pCloneNode = new SQLTreeNode(m_pSQLEditorControl.RenderWindowControl, m_pPostGISConnectionParams, m_pSQLEditorControl.rbnPanelQuery.Text);
      pCloneNode.SQLEditorControl.Query = this.SQLEditorControl.Query;
      pCloneNode.SQLEditorControl.FillColor = this.SQLEditorControl.FillColor;
      pCloneNode.SQLEditorControl.Outline = this.SQLEditorControl.Outline;
      pCloneNode.SQLEditorControl.Actor = this.SQLEditorControl.Actor;

      return pCloneNode;
    }

    public void Execute()
    {
      this.m_pSQLEditorControl.Execute();
    }

    public void RemoveWithCleanup()
    {
      this.Cleanup();
      this.Remove();
    }

    private void ContextMenuStripOnItemClickStart(object sender, ToolStripItemClickedEventArgs toolStripItemClickedEventArgs)
    {
      this.ContextMenuStrip.Hide();
      Application.DoEvents();

      switch (toolStripItemClickedEventArgs.ClickedItem.Text)
      {
        case "Uitvoeren":
          this.Execute();
          break;
        case "Verwijderen":
          this.RemoveWithCleanup();
          break;
      }
    }

    private void ContextMenuStripOnOpening(object sender, CancelEventArgs cancelEventArgs)
    {
      //var strip = sender as TreeNodeContextMenu;
      //if (strip != null)
      //{
      //  strip.Copy.Enabled = !string.IsNullOrEmpty(this.Text);
      //}
    }

    public string Naam
    {
      get
      {
        return this.Text;
      }
      set
      {
        this.Text = value;
        m_pSQLEditorControl.rbnPanelQuery.Text = value;
      }
    }

    public void Cleanup()
    {
      // Dispose of unmanaged resources.
      m_pSQLEditorControl.btnRemove_Click(this, null);
      m_pSQLEditorControl.Dispose();
      m_pSQLEditorControl = null;
    }

    private static System.Xml.Serialization.XmlSerializer serializer;
    #region Serialize/Deserialize
    private static System.Xml.Serialization.XmlSerializer Serializer
    {
      get
      {
        if ((serializer == null))
        {
          serializer = new System.Xml.Serialization.XmlSerializer(typeof(SQLTreeNode));
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
    public static bool Deserialize(string xml, out SQLTreeNode obj, out System.Exception exception)
    {
      exception = null;
      obj = default(SQLTreeNode);
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

    public static bool Deserialize(string xml, out SQLTreeNode obj)
    {
      System.Exception exception = null;
      return Deserialize(xml, out obj, out exception);
    }

    public static SQLTreeNode Deserialize(string xml)
    {
      System.IO.StringReader stringReader = null;
      try
      {
        stringReader = new System.IO.StringReader(xml);
        return ((SQLTreeNode)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
    public static bool LoadFromFile(string fileName, System.Text.Encoding encoding, out SQLTreeNode obj, out System.Exception exception)
    {
      exception = null;
      obj = default(SQLTreeNode);
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

    public static bool LoadFromFile(string fileName, out SQLTreeNode obj, out System.Exception exception)
    {
      return LoadFromFile(fileName, Encoding.UTF8, out obj, out exception);
    }

    public static bool LoadFromFile(string fileName, out SQLTreeNode obj)
    {
      System.Exception exception = null;
      return LoadFromFile(fileName, out obj, out exception);
    }

    public static SQLTreeNode LoadFromFile(string fileName)
    {
      return LoadFromFile(fileName, Encoding.UTF8);
    }

    public static SQLTreeNode LoadFromFile(string fileName, System.Text.Encoding encoding)
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

    private class TreeNodeContextMenu : MaterialContextMenuStrip
    {
      public readonly ToolStripItem Execute = new MaterialToolStripMenuItem { Text = "Uitvoeren" };
      public readonly ToolStripItem Remove = new MaterialToolStripMenuItem { Text = "Verwijderen" };
      public TreeNodeContextMenu()
      {
        Items.AddRange(new[] { Execute, Remove });
      }
    }
  }
}
