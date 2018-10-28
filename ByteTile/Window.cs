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
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    var newToggler = new BitToggler
                    {
                        row = y,
                        column = x
                    };
                    newToggler.Location = new Point(x * 42, y * 42);
                    Panel_Editor.Controls.Add(newToggler);
                }
            }
            rows = 8;
            columns = 8;
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
                    Console.WriteLine(binary);
                    vals.Add(Convert.ToInt64(binary, 2).ToString());
                }

                Output.Text += $"uint8_t row{r/8} = "+"{";
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
                        newToggler.Location = new Point((x * newToggler.Size.Width) / xmod,
                                                        (y * newToggler.Size.Width) / xmod);

                        newToggler.Size = new Size(newToggler.Size.Width / xmod,
                                                   newToggler.Size.Width / xmod);
                    }
                    else
                    {
                        newToggler.Location = new Point((x * newToggler.Size.Width) / ymod,
                                                        (y * newToggler.Size.Width) / ymod);

                        newToggler.Size = new Size(newToggler.Size.Width / ymod,
                                                   newToggler.Size.Width / ymod);
                    }

                    Panel_Editor.Controls.Add(newToggler);
                }
            }

            columns = (int)UpDown_GridX.Value;
            rows = (int)UpDown_GridY.Value;
        }
    }
}
