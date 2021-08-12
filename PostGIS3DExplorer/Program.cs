﻿using MaterialSkin;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostGIS3DExplorer
{
  static class Program
  {
    public static DBHelper DBHelper = null;

    //static public MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
    static public Color selectionColor = Color.Red;

    static public ResourceManager resourceManager; // declare Resource manager to access to specific cultureinfo
    static public CultureInfo CultureInfo;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      #region Try to upgrade previous user settings
      try
      {
        if (Properties.Settings.Default.UpdateRequired)
        {
          Properties.Settings.Default.Upgrade();
          Properties.Settings.Default.UpdateRequired = false;
          Properties.Settings.Default.Save();
        }
      }
      catch (Exception ex)
      {
      }
      #endregion

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      NpgsqlConnection.GlobalTypeMapper.UseNetTopologySuite();

      CultureInfo = CultureInfo.CurrentCulture;
      resourceManager = new ResourceManager("PostGIS3DExplorer.Resources.Res", typeof(Program).Assembly);

      //// Configure color schema
      //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
      //    Primary.Red400, Primary.Red600,
      //    Primary.Red700, Accent.Red200,
      //    TextShade.WHITE);
      //selectionColor = ((int)Primary.Red200).ToColor();
      //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FrmMain());
    }
  }
}
