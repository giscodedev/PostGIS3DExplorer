using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PostGIS3DExplorer
{
  [Serializable]
  public class SQLEditor
  {
    private Color fillColor = Color.FromArgb(200, 200, 0);
    private string m_sText = "";

    public string Sql { get; set; }


    public string Text
    {
      get
      {
        return m_sText.Trim();
      }
      set
      {
        m_sText = value.Trim();
      }
    }
    //public Color FillColor { get; set; } = Color.Gray;

    [XmlIgnore]
    public Color FillColor
    {
      get { return fillColor; }
      set { fillColor = value; }
    }

    [XmlElement("FillColor")]
    public string FillColorHtml
    {
      get { return ColorTranslator.ToHtml(fillColor); }
      set { fillColor = ColorTranslator.FromHtml(value); }
    }
  }
}
