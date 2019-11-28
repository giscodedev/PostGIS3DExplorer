using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PostGIS3DExplorer.Serialize
{
  [Serializable]
  public class Query
  {
    [XmlElement("Name")]
    public string Naam { get; set; }

    [XmlElement("SQL")]
    public string SQL { get; set; }

    [XmlElement("Size")]
    public int Grootte { get; set; }

    [XmlElement("Opacity")]
    public int Transparantie { get; set; }

    [XmlIgnore]
    public Color Vulkleur { get; set; }

    [XmlElement("FillColor")]
    public string FillColorAsArgb
    {
      get { return ColorTranslator.ToHtml(Vulkleur); }
      set { Vulkleur = ColorTranslator.FromHtml(value); }
    }

    [XmlElement("Outline")]
    public Boolean Omlijning { get; set; }

    public Query()
    {

    }

    public Query(SQLTreeNode pQNode)
    {
      Naam = pQNode.Text;
      SQL = pQNode.SQLEditorControl.Query;
      Vulkleur = pQNode.SQLEditorControl.FillColor;
      Omlijning = pQNode.SQLEditorControl.Outline;
      Grootte = pQNode.SQLEditorControl.PointSize;
      Transparantie = pQNode.SQLEditorControl.Opacity;
    }
  }
}
