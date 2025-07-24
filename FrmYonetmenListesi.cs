using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Microsoft.Data.SqlClient kütüphanesini kullanıyoruz.

namespace RozCineWorld
{
    public partial class FrmYonetmenListesi : Form
    {
        public FrmYonetmenListesi()
        {
            InitializeComponent();
        }
        // Sql bağlantısı için gerekli olan bağlantı dizesi.
        SqlConnection connection = new SqlConnection("Server= localhost;Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True;TrustServerCertificate=true;");
        private void btnkapat_Click(object sender, EventArgs e)// Kapatma butonuna tıklandığında formu kapatma işlemi için yazılan kod bloğu.
        {
            this.Close();
        }
        // Form yüklendiğinde yönetmen listesini veritabanından çekip listeleme işlemi için yazılan kod bloğu.
        private void FrmYonetmenListesi_Load(object sender, EventArgs e)
        {
            try// Bağlantı açma işlemi için gerekli olan kod bloğu.
            {
                ListePaneli.Controls.Clear();// ListePaneli içeriğini temizleme işlemi.
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string sorgu = "select * from Tbl_Yonetmenler ORDER BY AdSoyad ASC ";
                SqlCommand command = new SqlCommand(sorgu, connection);
                SqlDataReader oku = command.ExecuteReader();
                while (oku.Read())// Veritabanından okunan her bir yönetmen kaydı için YonetmenlerListesi kontrolünü oluşturma işlemi.
                {
                    YonetmenlerListesi arac = new YonetmenlerListesi();
                    arac.lblID.Text = oku["ID"].ToString();
                    arac.lblAdSoyad.Text = oku["AdSoyad"].ToString();
                    arac.pBResim.ImageLocation = oku["Resim"].ToString();
                    ListePaneli.Controls.Add(arac);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        // Yönetmen arama işlemi için yazılan kod bloğu.
        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            // Arama kutusuna yazılan metne göre yönetmen listesini filtreleme işlemi.
            try
            {
                ListePaneli.Controls.Clear();
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand arama = new SqlCommand("select * from Tbl_Yonetmenler where AdSoyad LIKE '%" + txtarama.Text + "%' collate Turkish_CI_AS ORDER BY AdSoyad ASC", connection);
                SqlDataReader oku = arama.ExecuteReader();
                while (oku.Read())// Veritabanından okunan her bir yönetmen kaydı için YonetmenlerListesi kontrolünü oluşturma işlemi.
                {
                    YonetmenlerListesi arac = new YonetmenlerListesi();
                    arac.lblID.Text = oku["ID"].ToString();
                    arac.lblAdSoyad.Text = oku["AdSoyad"].ToString();
                    arac.pBResim.ImageLocation = oku["Resim"].ToString();
                    ListePaneli.Controls.Add(arac);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
