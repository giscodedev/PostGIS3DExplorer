using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
  public partial class MaterialMessageBox : MaterialForm
  {
    static MaterialMessageBox newMessageBox;
    public Timer msgTimer;

    public MaterialMessageBox()
    {
      InitializeComponent();
    }

    //public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
    //{


    //}

    //public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
    //{
    //}

    //public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
    //{
    //}
    public static DialogResult Show(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
    {
      return Show(null, message, caption, buttons, icon);
    }

    public static DialogResult Show(IWin32Window owner, string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
    {
      newMessageBox = new MaterialMessageBox();
      newMessageBox.Text = caption;
      newMessageBox.lblMessage.Text = message;
      AddIcon(newMessageBox, icon);
      AddButtons(newMessageBox, buttons);

      return newMessageBox.ShowDialog(owner); 
    }

    private static void AddIcon(MaterialMessageBox newMessageBox, MessageBoxIcon icon)
    {
      switch (icon)
      {
        case MessageBoxIcon.Information:
          newMessageBox.picIcon.Image = new System.Drawing.Bitmap(newMessageBox.GetType().Assembly.GetManifestResourceStream("PostGIS3DExplorer.MaterialSkin.Resources.information.png"));
          break;
        case MessageBoxIcon.Question:
          newMessageBox.picIcon.Image = new System.Drawing.Bitmap(newMessageBox.GetType().Assembly.GetManifestResourceStream("PostGIS3DExplorer.MaterialSkin.Resources.question.png"));
          break;
        case MessageBoxIcon.Warning:
          newMessageBox.picIcon.Image = new System.Drawing.Bitmap(newMessageBox.GetType().Assembly.GetManifestResourceStream("PostGIS3DExplorer.MaterialSkin.Resources.warning.png"));
          break;
        case MessageBoxIcon.Stop:
          newMessageBox.picIcon.Image = new System.Drawing.Bitmap(newMessageBox.GetType().Assembly.GetManifestResourceStream("PostGIS3DExplorer.MaterialSkin.Resources.bug.png"));
          break;
      }
    }

    private static void AddButtons(MaterialMessageBox newMessageBox, MessageBoxButtons buttons)
    {
      newMessageBox.flowLayoutPanel1.Controls.Clear();

      MaterialRaisedButton pButton;
      Size pSize = new System.Drawing.Size(90, 36);
      Padding pMargin = new Padding(0, 0, 10, 20);

      switch (buttons)
      {
        case MessageBoxButtons.OK:
          pButton = new MaterialSkin.Controls.MaterialRaisedButton();
          pButton.Size = pSize;
          pButton.Margin = pMargin;
          pButton.Primary = true;
          pButton.Text = "OK";
          pButton.Tag = DialogResult.OK;
          pButton.Click += new System.EventHandler(newMessageBox.btn_Click);
          newMessageBox.flowLayoutPanel1.Controls.Add(pButton);
          break;
        case MessageBoxButtons.OKCancel:
          pButton = new MaterialSkin.Controls.MaterialRaisedButton();
          pButton.Size = pSize;
          pButton.Margin = pMargin;
          pButton.Primary = true;
          pButton.Text = "Annuleren";
          pButton.Tag = DialogResult.Cancel;
          pButton.Click += new System.EventHandler(newMessageBox.btn_Click);
          newMessageBox.flowLayoutPanel1.Controls.Add(pButton);
          pButton = new MaterialSkin.Controls.MaterialRaisedButton();
          pButton.Size = pSize;
          pButton.Margin = pMargin;
          pButton.Primary = true;
          pButton.Text = "OK";
          pButton.Tag = DialogResult.OK;
          pButton.Click += new System.EventHandler(newMessageBox.btn_Click);
          newMessageBox.flowLayoutPanel1.Controls.Add(pButton);
          break;
        case MessageBoxButtons.YesNo:
          pButton = new MaterialSkin.Controls.MaterialRaisedButton();
          pButton.Size = pSize;
          pButton.Margin = pMargin;
          pButton.Primary = true;
          pButton.Text = "Nee";
          pButton.Tag = DialogResult.No;
          pButton.Click += new System.EventHandler(newMessageBox.btn_Click);
          newMessageBox.flowLayoutPanel1.Controls.Add(pButton);
          pButton = new MaterialSkin.Controls.MaterialRaisedButton();
          pButton.Size = pSize;
          pButton.Margin = pMargin;
          pButton.Primary = true;
          pButton.Text = "Ja";
          pButton.Tag = DialogResult.Yes;
          pButton.Click += new System.EventHandler(newMessageBox.btn_Click);
          newMessageBox.flowLayoutPanel1.Controls.Add(pButton);
          break;
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.OK;
      newMessageBox.Dispose();
    }

    private void btn_Click(object sender, EventArgs e)
    {
      if (sender != null)
      {
        MaterialRaisedButton pButton = sender as MaterialRaisedButton;
        DialogResult = (DialogResult)pButton.Tag;
      }
      
      newMessageBox.Dispose();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
      newMessageBox.Dispose();
    }

    private void lblMessage_TextChanged(object sender, EventArgs e)
    {
      int iFormWidth = 430;
      int iFormHeight = 100;

      // Measure string.
      SizeF stringSize = new SizeF();
      Graphics pGraphics = Graphics.FromHwnd(this.Handle);
      //stringSize = pGraphics.MeasureString(newMessageBox.lblMessage.Text, newMessageBox.lblMessage.Font);
      stringSize = TextRenderer.MeasureText(newMessageBox.lblMessage.Text, newMessageBox.lblMessage.Font);

      if ((int)stringSize.Width + 80 > iFormWidth)
      {
        iFormWidth = (int)stringSize.Width;
      }

      // Make sure the width is smaller than the screen width
      Screen pScreen = Screen.FromHandle(this.Handle);
      if (pScreen.WorkingArea.Width - 140 < iFormWidth)
      {
        iFormWidth = pScreen.WorkingArea.Width - 140;
      }
      this.Width = iFormWidth + 80;





      if ((int)stringSize.Height > iFormHeight)
      {
        iFormHeight = (int)stringSize.Height;
      }

      if (pScreen.WorkingArea.Height - 160 < iFormHeight)
      {
        iFormHeight = pScreen.WorkingArea.Height - 160;
      }
      this.Height = iFormHeight + 160;


    }
  }
}