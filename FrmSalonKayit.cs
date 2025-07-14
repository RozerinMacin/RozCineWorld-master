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
    public partial class FrmSalonKayit : Form
    {
        public FrmSalonKayit()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnSalonKaydet_Click(object sender, EventArgs e)
        {
            if (txtSalonAdi.Text != "" && cBkoltukSayisi.Text != "")
            {
                connection.Open();
                SqlCommand kaydet = new SqlCommand("INSERT INTO Tbl_Salonlar(SalonAdı,KoltukSayısı) VALUES(@salonadi,@koltuksayisi)", connection);
                kaydet.Parameters.AddWithValue("@salonadi", txtSalonAdi.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@koltuksayisi", cBkoltukSayisi.Text);
                kaydet.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("SALON KAYDETME İŞLEMİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİRİLDİ!");
                txtSalonAdi.Text = "";
                cBkoltukSayisi.Text = "";
                txtSalonAdi.Focus();
                ListeGetir();
            }
            else
            {
                MessageBox.Show("LÜTFEN TÜM ALANLARI EKSİKSİZ BİR ŞEKİLDE DOLDURUNUZ!");
            }
        }
        void koltukolustur()
        {
            for (int i = 1; i < 100; i++)
            {
                cBkoltukSayisi.Items.Add(i);
            }
        }

        private void FrmSalonKayit_Load(object sender, EventArgs e)
        {
            koltukolustur();
            ListeGetir();
        }
        void ListeGetir()
        {
            Panelsalon.Controls.Clear();
            connection.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Salonlar ORDER BY SalonAdı ASC", connection);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                SalonListesi arac = new SalonListesi();
                arac.lblsalonadi.Text = oku["Salonadı"].ToString();
                arac.lblkoltuksayisi.Text = oku["KoltukSayısı"].ToString();
                Panelsalon.Controls.Add(arac);
            }
            connection.Close();
        }
    }
}
