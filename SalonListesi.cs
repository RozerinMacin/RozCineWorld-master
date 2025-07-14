using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozCineWorld
{
    public partial class SalonListesi : UserControl
    {
        public SalonListesi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");
        private void gel(object sender, MouseEventArgs e)
        {
            lblsalonadi.ForeColor = Color.White;
        }

        private void ayrıl(object sender, EventArgs e)
        {
            lblsalonadi.ForeColor = Color.FromArgb(16, 46, 80);
        }

    }
}
