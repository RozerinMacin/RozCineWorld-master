using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RozCineWorld
{
    public partial class FrmYonetmenListesi : Form
    {
        public FrmYonetmenListesi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmYonetmenListesi_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            string sorgu = "select * from Tbl_Yonetmenler ORDER BY AdSoyad ASC ";
            SqlCommand command = new SqlCommand(sorgu, connection);
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read())
            {
                YonetmenlerListesi arac = new YonetmenlerListesi();
                arac.lblID.Text = oku["ID"].ToString();
                arac.lblAdSoyad.Text = oku["AdSoyad"].ToString();
                arac.pBResim.ImageLocation = oku["Resim"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close();
        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            SqlCommand arama = new SqlCommand("select * from Tbl_Yonetmenler where AdSoyad LIKE '%"+txtarama.Text+"%' collate Turkish_CI_AS ORDER BY AdSoyad ASC", connection);
            SqlDataReader oku = arama.ExecuteReader();
            while (oku.Read())
            {
                YonetmenlerListesi arac = new YonetmenlerListesi();
                arac.lblID.Text = oku["ID"].ToString();
                arac.lblAdSoyad.Text = oku["AdSoyad"].ToString();
                arac.pBResim.ImageLocation = oku["Resim"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close();
        }
    }
}
