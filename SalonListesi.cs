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
        private void gel(object sender, MouseEventArgs e)// Fare imleci label üzerine geldiğinde yazı rengini beyaz yapma işlemi için yazılan kod bloğu.
        {
            lblsalonadi.ForeColor = Color.White;
        }

        private void ayrıl(object sender, EventArgs e)// Fare imleci label üzerinden ayrıldığında yazı rengini mavi yapma işlemi için yazılan kod bloğu.
        {
            lblsalonadi.ForeColor = Color.FromArgb(16, 46, 80);
        }

    }
}
