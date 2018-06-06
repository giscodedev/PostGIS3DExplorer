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
  public class ConnectionTreeNode : TreeNode
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
      }
    }

    public ConnectionTreeNode(PostGISConnectionParams pPostGISConnectionParams) : base()
    {
      m_pPostGISConnectionParams = pPostGISConnectionParams;

      //this.ImageKey = "connection";
      //this.SelectedImageKey = "connection";
      this.ImageIndex = 1;
      this.SelectedImageIndex = 1;

      this.Text = m_pPostGISConnectionParams.Name;

      TreeNodeContextMenu cms = new TreeNodeContextMenu();
      cms.Opening += ContextMenuStripOnOpening;
      cms.OnItemClickStart += ContextMenuStripOnItemClickStart;
      this.ContextMenuStrip = cms;
    }

    private void ContextMenuStripOnItemClickStart(object sender, ToolStripItemClickedEventArgs toolStripItemClickedEventArgs)
    {
      if (toolStripItemClickedEventArgs.ClickedItem.Text == Program.resourceManager.GetString("PROPERTIES", Program.CultureInfo))
      {
        this.EditProperties();
      }
      if (toolStripItemClickedEventArgs.ClickedItem.Text == Program.resourceManager.GetString("QUERY_REMOVE", Program.CultureInfo))
      {
        this.Remove();
      }

    }

    public void EditProperties()
    {
      FrmConnection pFrmConnection = new FrmConnection();
      pFrmConnection.PostGISConnectionParams = this.PostGISConnectionParams;
      if (pFrmConnection.ShowDialog() == DialogResult.OK)
      {
        PostGISConnectionParams pPostGISConnectionParams = pFrmConnection.PostGISConnectionParams;
        this.PostGISConnectionParams = pFrmConnection.PostGISConnectionParams;
        this.Text = this.PostGISConnectionParams.Name;
      }
    }

    private void ContextMenuStripOnOpening(object sender, CancelEventArgs cancelEventArgs)
    {
      var strip = sender as TreeNodeContextMenu;
      if (strip != null)
      {
        strip.Properties.Text = Program.resourceManager.GetString("PROPERTIES", Program.CultureInfo);
        strip.Remove.Text = Program.resourceManager.GetString("QUERY_REMOVE", Program.CultureInfo);

        strip.Remove.Enabled = this.Nodes.Count == 0;
      }
    }

    private class TreeNodeContextMenu : MaterialContextMenuStrip
    {
      public readonly ToolStripItem Properties = new MaterialToolStripMenuItem { Text = Program.resourceManager.GetString("PROPERTIES", Program.CultureInfo) };
      public readonly ToolStripItem Remove = new MaterialToolStripMenuItem { Text = Program.resourceManager.GetString("QUERY_REMOVE", Program.CultureInfo) };
      public TreeNodeContextMenu()
      {
        Items.AddRange(new[] { Properties, Remove });
      }
    }
  }
}
