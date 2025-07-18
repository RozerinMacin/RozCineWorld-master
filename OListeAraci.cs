using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozCineWorld
{
    public partial class OListeAraci : UserControl
    {
        public OListeAraci()
        {
            InitializeComponent();
        }

        private void lbladi_Click(object sender, EventArgs e)
        {
            if (lbladi.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lbladi.ForeColor = Color.White;
            }
            else
            {
                lbladi.ForeColor = Color.FromArgb(16, 46, 80);
            }
        }

        private void lbladi_MouseMove(object sender, MouseEventArgs e)
        {
            lbladi.Font = new Font(lbladi.Font.Name, 10, FontStyle.Underline);
        }

        private void lbladi_MouseLeave(object sender, EventArgs e)
        {
            lbladi.Font = new Font(lbladi.Font.Name, 10, FontStyle.Regular);
        }
    }
}
