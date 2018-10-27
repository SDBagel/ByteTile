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
                    newToggler.Location = new Point(20+x*45, 20+y*45);
                    Controls.Add(newToggler);
                }
            }
        }
        
        private List<BitToggler> GetBitTogglers()
        {
            List<BitToggler> bitTogglers = new List<BitToggler>();
            foreach (Control control in Controls)
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

            List<int> vals = new List<int>();

            List<BitToggler> bts = GetBitTogglers();
            for (int i = 0; i < 8; i++)
            {
                List<BitToggler> colBT = new List<BitToggler>();
                colBT.AddRange(from bt in bts
                               where bt.column == i
                               select bt);

                string binary = "";
                foreach (BitToggler bt in colBT)
                {
                    if (bt.isToggled)
                        binary += "1";
                    else
                        binary += "0";
                }
                
                vals.Add(Convert.ToInt32(binary, 2));
            }
            vals.Reverse();
            foreach(int val in vals)
            {
                richTextBox1.Text += $"{val.ToString()}, ";
            }
        }
    }
}
