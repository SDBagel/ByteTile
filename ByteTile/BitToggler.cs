using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteTile
{
    public partial class BitToggler : UserControl
    {
        public int column = 0;
        public int row = 0;
        public bool isToggled = false;

        public BitToggler()
        {
            InitializeComponent();
        }

        private void BitToggler_MouseDown(object sender, MouseEventArgs e)
        {
            if (isToggled)
            {
                BackColor = Color.White;
                isToggled = false;
            }
            else
            {
                BackColor = Color.Black;
                isToggled = true;
            }
            BitToggler_MouseEnter(sender, e);   
        }

        private void BitToggler_MouseEnter(object sender, EventArgs e)
        {
            if (isToggled)
                BackColor = Color.FromArgb(60, 60, 60);
            else
                BackColor = Color.LightGray;
        }

        private void BitToggler_MouseLeave(object sender, EventArgs e)
        {
            if (isToggled)
                BackColor = Color.Black;
            else
                BackColor = Color.White;
        }
    }
}
