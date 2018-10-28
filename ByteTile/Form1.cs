using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteTile
{
    public partial class Form1 : Form
    {
        private int rows;
        private int columns;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
                    newToggler.Location = new Point(x*42, y*42);
                    panel1.Controls.Add(newToggler);
                }
            }
            rows = 8;
            columns = 8;
        }
        
        private List<BitToggler> GetBitTogglers()
        {
            List<BitToggler> bitTogglers = new List<BitToggler>();
            foreach (Control control in panel1.Controls)
            {
                if (control.GetType().Equals(typeof(BitToggler)))
                {
                    bitTogglers.Add((BitToggler)control);
                }
            }
            return bitTogglers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<BitToggler> bts = GetBitTogglers();
            foreach (BitToggler bt in bts)
            {
                bt.BackColor = Color.White;
                bt.isToggled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            List<BitToggler> bts = GetBitTogglers();
            for (int r = 0; r < rows; r += 8)
            {
                List<string> vals = new List<string>(64);
                for (int i = 0; i < columns; i++)
                {
                    List<BitToggler> colBT = new List<BitToggler>();
                    colBT.AddRange(from bt in bts
                                   where bt.column == i && bt.row <= r+7
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

                richTextBox1.Text += "{";
                foreach (string val in vals)
                {
                    richTextBox1.Text += $"{val}, ";
                }
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 2);
                richTextBox1.Text += "} \n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            for (int x = 0; x < numericUpDown1.Value; x++)
            {
                for (int y = 0; y < numericUpDown2.Value; y++)
                {
                    var newToggler = new BitToggler
                    {
                        row = y,
                        column = x
                    };

                    int xmod = (int)numericUpDown1.Value / 8;
                    int ymod = (int)numericUpDown2.Value / 8;
                    
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

                    panel1.Controls.Add(newToggler);
                }
            }

            columns = (int)numericUpDown1.Value;
            rows = (int)numericUpDown2.Value;
        }
    }
}
