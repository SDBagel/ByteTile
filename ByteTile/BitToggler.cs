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
            if (BackColor.Equals(Color.Black))
            {
                BackColor = Color.White;
                isToggled = false;
            }
            else
            {
                BackColor = Color.Black;
                isToggled = true;
            }
                
        }
    }
}
