using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MaterialSkin.Controls
{
  [Serializable]
  public class AdvancedTreeView : DragDropReorderTreeView
  {

    public void materialTreeView()
    {
      SelectedFocusColor = Color.Red;
      SelectedLostFocusColor = Color.LightGray;

    }

    public Color SelectedFocusColor { get; set; }
    public Color SelectedLostFocusColor { get; set; }

    public void ClearWithCleanup()
    {
      for (int iConn = this.Nodes.Count - 1; iConn >= 0; iConn--)
      {
        TreeNode pTreeNode = this.Nodes[iConn];
        for (int iQuery = pTreeNode.Nodes.Count - 1; iQuery >= 0; iQuery--)
        {
          TreeNode pSubNode = pTreeNode.Nodes[iQuery];
          if (pSubNode is SQLTreeNode)
          {
            SQLTreeNode pSQLTreeNode = pSubNode as SQLTreeNode;
            pSQLTreeNode.Cleanup();
          }
          pTreeNode.Nodes.Remove(pSubNode);
        }
        this.Nodes.Remove(pTreeNode);
      }
    }

    protected override void OnDrawNode(DrawTreeNodeEventArgs e)
    {
      TreeNodeStates treeState = e.State;
      Font treeFont = e.Node.NodeFont ?? e.Node.TreeView.Font;

      // Colors.
      Color foreColor = e.Node.ForeColor;

      // Brushes
      SolidBrush selectedTreeBrush = new SolidBrush(this.SelectedFocusColor);
      SolidBrush deselectedTreeBrush = new SolidBrush(this.SelectedLostFocusColor);

      // Set default font color.
      if (foreColor == Color.Empty)
      {
        foreColor = e.Node.TreeView.ForeColor;
      }

      // Draw bounding box and fill.
      if (e.Node == e.Node.TreeView.SelectedNode)
      {
        // Use appropriate brush depending on if the tree has focus.
        if (this.Focused)
        {
          //foreColor = SystemColors.HighlightText;
          e.Graphics.FillRectangle(selectedTreeBrush, e.Bounds);
          //ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds, foreColor, SystemColors.Highlight);
          TextRenderer.DrawText(e.Graphics, e.Node.Text, treeFont, e.Bounds,
                                       foreColor, TextFormatFlags.GlyphOverhangPadding);
        }
        else
        {
          e.Graphics.FillRectangle(deselectedTreeBrush, e.Bounds);
          //ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds, foreColor, SystemColors.Highlight);
          TextRenderer.DrawText(e.Graphics, e.Node.Text, treeFont, e.Bounds,
                                       foreColor, TextFormatFlags.GlyphOverhangPadding);
        }
      }
      else
      {
        if ((e.State & TreeNodeStates.Hot) == TreeNodeStates.Hot)
        {
          e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
          TextRenderer.DrawText(e.Graphics, e.Node.Text, treeFont, e.Bounds,
                                       System.Drawing.Color.Black, TextFormatFlags.GlyphOverhangPadding);
        }
        else
        {
          e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
          TextRenderer.DrawText(e.Graphics, e.Node.Text, treeFont, e.Bounds,
                                       foreColor, TextFormatFlags.GlyphOverhangPadding);
        }
      }
    }
  }
}
