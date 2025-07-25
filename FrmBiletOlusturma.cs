using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;// SqlConnection sınıfını kullanmak için gerekli kütüphane

namespace RozCineWorld
{
    public partial class FrmBiletOlusturma : Form
    {
        public FrmBiletOlusturma()
        {
            InitializeComponent();
        }
        // SqlConnection sınıfından bir bağlantı nesnesi oluşturuyoruz.
        SqlConnection connection = new SqlConnection("Server= localhost;Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True;TrustServerCertificate=true;");
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close(); // Bilet oluşturma formunu kapatır
        }

        private void FrmBiletOlusturma_Load(object sender, EventArgs e)
        {
            FilmAdiGetir();
        }
        void FilmAdiGetir()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open(); // Veritabanı bağlantısını açar
                }
                string sorgu = "select * from Tbl_Filmler ORDER BY Film_Adi ASC";
                SqlCommand command = new SqlCommand(sorgu, connection);
                SqlDataReader oku = command.ExecuteReader(); // Sorguyu çalıştırır ve verileri okur
                while (oku.Read())
                {
                    cBFilmAdi.Items.Add(oku["Film_Adi"]?.ToString()??"Film Adı hatalı."); // Film adlarını combobox'a ekler
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
                    connection.Close(); // Veritabanı bağlantısını kapatır
                }
            }
        }
    }
}
