using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ByteTile
{
    public partial class Window : Form
    {
        private int rows;
        private int columns;

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            Panel_GridOptions.Hide();
            Icon_Loading.Hide();

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    var newToggler = new BitToggler
                    {
                        row = y,
                        column = x
                    };
                    newToggler.Location = new Point(x * 43, y * 43);
                    Panel_Editor.Controls.Add(newToggler);
                }
            }
            rows = 8;
            columns = 8;
        }
        
        private void Button_GridOptions_Click(object sender, EventArgs e)
        {
            if (Panel_GridOptions.Visible)
                Panel_GridOptions.Hide();
            else
                Panel_GridOptions.Show();
        }

        private List<BitToggler> GetBitTogglers()
        {
            List<BitToggler> bitTogglers = new List<BitToggler>();
            foreach (Control control in Panel_Editor.Controls)
            {
                if (control.GetType().Equals(typeof(BitToggler)))
                {
                    bitTogglers.Add((BitToggler)control);
                }
            }
            return bitTogglers;
        }

        private void ResetGrid_Click(object sender, EventArgs e)
        {
            List<BitToggler> bts = GetBitTogglers();
            foreach (BitToggler bt in bts)
            {
                bt.BackColor = Color.White;
                bt.isToggled = false;
            }
            Panel_GridOptions.Hide();
        }

        private void InvertGrid_Click(object sender, EventArgs e)
        {
            List<BitToggler> bts = GetBitTogglers();
            foreach (BitToggler bt in bts)
            {
                if (bt.BackColor == Color.White)
                    bt.BackColor = Color.Black;
                else
                    bt.BackColor = Color.White;

                bt.isToggled = !bt.isToggled;
            }
            Panel_GridOptions.Hide();
        }

        private void GenerateCode_Click(object sender, EventArgs e)
        {
            Output.Text = "";

            List<BitToggler> bts = GetBitTogglers();
            List<string> vals = new List<string>(512);
            for (int r = 0; r < rows; r += 8)
            {
                for (int i = 0; i < columns; i++)
                {
                    List<BitToggler> colBT = new List<BitToggler>();
                    colBT.AddRange(from bt in bts
                                   where bt.column == i && bt.row <= r+7 && bt.row >= r
                                   select bt);
                    colBT.Reverse();
                    string binary = "";
                    foreach (BitToggler bt in colBT)
                    {
                        if (bt.isToggled)
                            binary += "1";
                        else
                            binary += "0";
                    }
                    vals.Add(Convert.ToInt64(binary, 2).ToString());
                }

                Output.Text += $"uint8_t row{r/8}[{columns}] = "+"{";
                foreach (string val in vals)
                {
                    Output.Text += $"{val}, ";
                }
                Output.Text = Output.Text.Substring(0, Output.Text.Length - 2);
                Output.Text += "}; \n";
                vals.Clear();
            }
        }

        private void GenerateGrid_Click(object sender, EventArgs e)
        {
            Panel_Editor.Hide();
            Panel_GridOptions.Hide();
            Icon_Loading.Show();
            Panel_Editor.Controls.Clear();

            for (int x = 0; x < UpDown_GridX.Value; x++)
            {
                for (int y = 0; y < UpDown_GridY.Value; y++)
                {
                    var newToggler = new BitToggler
                    {
                        row = y,
                        column = x
                    };

                    int xmod = (int)UpDown_GridX.Value / 8;
                    int ymod = (int)UpDown_GridY.Value / 8;

                    if (xmod > ymod)
                    {
                        newToggler.Location = new Point((x * (newToggler.Size.Width + 1) / xmod) + x,
                                                        (y * (newToggler.Size.Width + 1) / xmod) + y);

                        newToggler.Size = new Size(newToggler.Size.Width / xmod,
                                                   newToggler.Size.Width / xmod);
                    }
                    else
                    {
                        newToggler.Location = new Point((x * (newToggler.Size.Width+1) / ymod) + x,
                                                        (y * (newToggler.Size.Width+1) / ymod) + y);

                        newToggler.Size = new Size(newToggler.Size.Width / ymod,
                                                   newToggler.Size.Width / ymod);
                    }

                    Panel_Editor.Controls.Add(newToggler);
                    Icon_Loading.Invalidate();
                    Icon_Loading.Update();
                }
            }

            Icon_Loading.Hide();
            Panel_Editor.Show();

            columns = (int)UpDown_GridX.Value;
            rows = (int)UpDown_GridY.Value;
        }

        #region Window Controls

        private bool mouseDown;
        private Point lastLocation;

        private void Window_ControlBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Window_ControlBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Window_ControlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((Location.X - lastLocation.X) + e.X,
                                          (Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Window_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Window_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Control bt = (Control)sender;
            bt.BackColor = Color.FromArgb(40, 45, 55);
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Control bt = (Control)sender;
            bt.BackColor = Color.FromArgb(20, 25, 35);
        }
        #endregion
    }
}
