using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;// sql kütüphanesi
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozCineWorld
{
    public partial class FrmOyuncuListesi : Form
    {
        public FrmOyuncuListesi()
        {
            InitializeComponent();
        }
        private void btnkapat_Click(object sender, EventArgs e)// Kapatma butonuna tıklandığında çalışacak kod
        {
            this.Close();
        }
        // sqlconnection nesnesi oluşturuz.
        SqlConnection connection = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");

        private void FrmOyuncuListesi_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde oyuncu listesini yükle
            try
            {
                ListePaneli.Controls.Clear();
                // Bağlantı kapalıysa aç
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }

                string sorgu = "SELECT * FROM Tbl_Oyuncular ORDER BY AdSoyad ASC";
                SqlCommand command = new SqlCommand(sorgu, connection);
                SqlDataReader oku = command.ExecuteReader();
                while (oku.Read())// DataReader ile verileri oku ve listeye ekle
                {
                    OyuncuListesi arac = new OyuncuListesi();
                    arac.lblID.Text = oku["ID"].ToString();
                    arac.lblAdSoyad.Text = oku["AdSoyad"].ToString();
                    arac.pBResim.ImageLocation = oku["Resim"].ToString();
                    ListePaneli.Controls.Add(arac);
                }
                oku.Close(); // DataReader'ı da mutlaka kapatmalısın
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oyuncu listesi yüklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantı açıksa kapat
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            // Arama metni değiştiğinde oyuncu listesini filtrele işlemi yapmaya yarayan kod bloğu
            try
            {
                ListePaneli.Controls.Clear();
                // Bağlantı kapalıysa aç
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                string sorgu = "SELECT * FROM Tbl_Oyuncular WHERE AdSoyad LIKE @arama COLLATE Turkish_CI_AS ORDER BY AdSoyad ASC";
                SqlCommand arama = new SqlCommand(sorgu, connection);
                arama.Parameters.AddWithValue("@arama", "%" + txtarama.Text + "%");
                SqlDataReader oku = arama.ExecuteReader();
                while (oku.Read())
                {
                    OyuncuListesi arac = new OyuncuListesi();
                    arac.lblID.Text = oku["ID"].ToString();
                    arac.lblAdSoyad.Text = oku["AdSoyad"].ToString();
                    arac.pBResim.ImageLocation = oku["Resim"].ToString();
                    ListePaneli.Controls.Add(arac);
                }
                oku.Close(); // DataReader'ı mutlaka kapat
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama yapılırken bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantı hâlâ açıksa kapat
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
