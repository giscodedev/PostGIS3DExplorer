using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostGIS3DExplorer.Serialize
{
  [Serializable]
  public class Connection
  {
    public List<Query> Queries { get; set; }
    public PostGISConnectionParams PostGISConnection { get; set; }

    public Connection()
    {
      Queries = new List<Query>();
    }

    public Connection(ConnectionTreeNode pCNode)
    {
      PostGISConnection = pCNode.PostGISConnectionParams;

      Queries = new List<Query>();
      foreach (TreeNode pQNode in pCNode.Nodes)
      {
        if (pQNode is SQLTreeNode)
        {
          Query pQuery = new Query(pQNode as SQLTreeNode);
          Queries.Add(pQuery);
        }
      }
    }

  }
}
