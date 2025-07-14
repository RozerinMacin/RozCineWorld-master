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
    public partial class YonetmenlerListesi : UserControl
    {
        public YonetmenlerListesi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");

        private void YonetmenlerListesi_Load(object sender, EventArgs e)
        {
            connection.Open();
            string sorgu = "select * from Tbl_Yonetmenler where ID = @p1";
            SqlCommand command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@p1", lblID.Text);
            SqlDataReader oku = command.ExecuteReader();
            if (oku.Read())
            {
                lblCinsiyet.Text = oku["Cinsiyet"].ToString();
            }
            connection.Close();
        }

        private void btndetay_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sorgu = "select * from Tbl_Yonetmenler where ID = @p1";
            SqlCommand command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@p1", lblID.Text);
            SqlDataReader oku = command.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("BİYOGRAFİ: " + oku["Biyografi"].ToString(),oku["AdSoyad"].ToString());
            }
            connection.Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sil = new SqlCommand("delete from Tbl_Yonetmenler where ID = @p1", connection);
            sil.Parameters.AddWithValue("@p1",lblID.Text);
            sil.ExecuteNonQuery();
            connection.Close();
            this.Hide();
            MessageBox.Show(lblAdSoyad.Text + " ADLI YÖNETMEN KAYDI BAŞARILI BİR ŞEKİLDE SİLİNMİŞTİR.");
        }
    }
}
