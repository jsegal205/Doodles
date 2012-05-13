using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;



namespace Doodle
{
  public partial class Form1 : Form
  {

#region ###Global Variables
    private Graphics _g;
    private static Random random = new Random();
    private Color _fillcolor = new Color();
    private Color _drawcolor = new Color();
    private bool _bIsMouseDown = false;
    private bool _bIsFillColorChosen = false;
    private bool _bIsDrawColorChosen = false;
    private bool _bIsGraphicsSet = false;
    private int _iSize = 0; //0 = random, 1 = small, 2 = medium, 3 = large
    private int _iDrawSize = 5;
#endregion

    public Form1()
    {
      InitializeComponent();
      MakeSizeBtnsUniform();
      MakeBtnBold(btnSizeRandom);
      txtDrawSize.Text = "5";
    }

#region ###Shape Events
    private void DrawRectangle(MouseEventArgs e)
    {
      if (!rbtnDrawNone.Checked || !rbtnFillNone.Checked)
      {
        System.Drawing.Rectangle r = CreateRectangle(e);

        if (rbtnPen.Checked)
        {
          r = new Rectangle(e.X - 1, e.Y - 1, 2, 2);
          SolidBrush brsh = ChooseFillColor();
          _g.FillRectangle(brsh, r);
        }

        if (rbtnFillEllipse.Checked)
        {
          SolidBrush brsh = ChooseFillColor();
          _g.FillEllipse(brsh, r);
        }
        if (rbtnFillRectangle.Checked)
        {
          SolidBrush brsh = ChooseFillColor();
          _g.FillRectangle(brsh, r);
        }
        if (rbthDrawEllipse.Checked)
        {
          Pen pen = ChooseDrawColor();
          _g.DrawEllipse(pen, r);
        }
        if (rbtnDrawRectangle.Checked)
        {
          Pen pen = ChooseDrawColor();
          _g.DrawRectangle(pen, r);
        }
      }
    }

    private Rectangle CreateRectangle(MouseEventArgs e)
    {
      int h = 0; 
      int w = 0; 

      switch (_iSize)
      {
        case 0: 
          h = RandomNumber(1, 50);
          w = RandomNumber(1, 50);
          break;
        case 1:
          h = 10;
          w = 10;
          break;
        case 2:
          h = 30;
          w = 30;
          break;
        case 3:
          h = 60;
          w = 60;
          break;
      }
      return new Rectangle(e.X - (w / 2), e.Y - (h / 2), w, h);
    }

    private SolidBrush ChooseFillColor()
    {
      if (!_bIsFillColorChosen)
      {
        return new SolidBrush(Color.FromArgb(RandomNumber(256), RandomNumber(256), RandomNumber(256)));
      }
      return new SolidBrush(_fillcolor);
    }

    private Pen ChooseDrawColor()
    {
      if (!_bIsDrawColorChosen)
      {
        return new Pen(Color.FromArgb(RandomNumber(256), RandomNumber(256), RandomNumber(256)), _iDrawSize);
      }
      return new Pen(_drawcolor, _iDrawSize);
    }

    private int RandomNumber(int max)
    {
      return random.Next(max);
    }

    private int RandomNumber(int min, int max)
    {
      return random.Next(min, max);
    }
#endregion

#region ###Mouse Events
    private void picCanvas_MouseDown(object sender, MouseEventArgs e)
    {
      if (!_bIsGraphicsSet) _g = picCanvas.CreateGraphics();
      _bIsMouseDown = true;
      DrawRectangle(e);
    }

    private void picCanvas_MouseMove(object sender, MouseEventArgs e)
    {
      if (_bIsMouseDown) DrawRectangle(e);
    }

    private void picCanvas_MouseUp(object sender, MouseEventArgs e)
    {
      _bIsMouseDown = false;
    }
#endregion

#region ###Clear Functions
    //clears canvas with ESC and Enter
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      if (keyData == Keys.Escape) picCanvas.Refresh();
      return base.ProcessCmdKey(ref msg, keyData);
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      picCanvas.Refresh();
    }

    private void btnreset_Click(object sender, EventArgs e)
    {
      _bIsDrawColorChosen = false;
      _bIsFillColorChosen = false;
      picFill.BorderStyle = BorderStyle.Fixed3D;
      picDraw.BorderStyle = BorderStyle.Fixed3D;
      picFill.BackColor = System.Drawing.Color.FromName("Control");
      picDraw.BackColor = System.Drawing.Color.FromName("Control");
    }

    private void Form1_Resize(object sender, EventArgs e)
    {
      _bIsGraphicsSet = false;
    }
    #endregion

#region ###Color Buttons
    private void btnFillColor_Click(object sender, EventArgs e)
    {
      if (colorDialog1.ShowDialog() == DialogResult.Cancel)
      {
        if (_fillcolor.IsEmpty) _bIsFillColorChosen = false;
      }
      else
      {
        _fillcolor = colorDialog1.Color;
        _bIsFillColorChosen = true;
        picFill.BackColor = _fillcolor;
        picFill.BorderStyle = BorderStyle.None;
      }
    }

    private void btnDrawColor_Click(object sender, EventArgs e)
    {
      if (colorDialog1.ShowDialog() == DialogResult.Cancel)
      {
        if (_drawcolor.IsEmpty) _bIsDrawColorChosen = false;
      }
      else
      {
        _drawcolor = colorDialog1.Color;
        _bIsDrawColorChosen = true;
        picDraw.BackColor = _drawcolor;
        picDraw.BorderStyle = BorderStyle.None;
      }
    }
    #endregion

#region ###Size Buttons
    private void HandleBtnClick(object sender, EventArgs e)
      // handles btnSizeSmall, btnSizeMedium, btnSizeLarge, btnSizeRandom
    {
      MakeSizeBtnsUniform();

      switch (sender.ToString().Remove(0, sender.ToString().IndexOf(":") + 2))
      {
        case "S":
          {
            MakeBtnBold(btnSizeSmall);
            _iSize = 1;
            break;
          }
        case "M":
          {
            MakeBtnBold(btnSizeMedium);
            _iSize = 2;
            break;
          }
        case "L":
          {
            MakeBtnBold(btnSizeLarge);
            _iSize = 3;
            break;
          }
        case "Random Size":
          {
            MakeBtnBold(btnSizeRandom);
            _iSize = 0;
            break;
          }
      }
    }

    private void MakeSizeBtnsUniform()
    {
      Font RegFont = new Font(Font, FontStyle.Regular);
      btnSizeSmall.Font = RegFont;
      btnSizeMedium.Font = RegFont;
      btnSizeLarge.Font = RegFont;
      btnSizeRandom.Font = RegFont;
    }

    private void MakeBtnBold(Button b)
    {
      Font BoldFont = new Font(Font, FontStyle.Bold);
      b.Font = BoldFont;
    }
    #endregion

#region ###DrawSize Events
    private void txtDrawSize_KeyPress(object sender, KeyPressEventArgs e)
    {
      bool bHandled = false;
      bHandled = !char.IsDigit(e.KeyChar);
      if (e.KeyChar == (char)Keys.Back) bHandled = false;
      if (e.KeyChar == (char)Keys.Enter)
      {
        DrawSizeSubmit();
        bHandled = false;
      }
      e.Handled = bHandled;
    }

    private void btnDrawSize_Click(object sender, EventArgs e)
    {
      DrawSizeSubmit();
    }

    private void DrawSizeSubmit()
    {
      bool fValid = true;
      foreach (char c in txtDrawSize.Text.ToCharArray())
      {
        if (!char.IsDigit(c)) fValid = false;
      }

      if (fValid)
      {
        if (txtDrawSize.Text.Trim() == string.Empty || txtDrawSize.Text == "0")
        {
          _iDrawSize = 5;
          txtDrawSize.Text = "5";
        }
        else
        {
          _iDrawSize = Convert.ToInt32(txtDrawSize.Text);
        }
      }
      else 
      {
        MessageBox.Show("Invalid Size entered: " + txtDrawSize.Text, "Doodle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }

    private void txtDrawSize_Enter(object sender, EventArgs e)
    {
      txtDrawSize.Focus();
      txtDrawSize.SelectAll();
    }
#endregion

  }
}
