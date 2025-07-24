using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;//sql bağlantısı için gerekli kütüphane

namespace RozCineWorld
{
    public partial class FrmFilmDetay : Form
    {
        public FrmFilmDetay()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server= localhost;Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True;TrustServerCertificate=true;");
        public string IdNo = "";// Formdan gelen IdNo bilgisi ile doldurulacak film detayları için kullanılacak değişken
        private void FrmFilmDetay_Load(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "select * from Tbl_Filmler where ID = @id";
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@id", IdNo);
                SqlDataReader oku = command.ExecuteReader();
                if (oku.Read())
                {
                    lblFilmAdi.Text = oku["Film_Adi"].ToString();
                    pBResim.ImageLocation = oku["Film_Afisi"].ToString();
                    lblyonetmen.Text = oku["Film_Yonetmeni"].ToString();
                    lbloyuncu.Text= oku["Film_Oyuncuları"].ToString();
                    lbltur.Text = oku["Film_Türü"].ToString();
                    lblozellikler.Text = oku["Film_Ozellikleri"].ToString();
                    lblbicim.Text = oku["Film_Bicimi"].ToString();
                    lbldetay.Text  = oku["Film_Detayi"].ToString();
                    lblIMDB.Text = oku["Film_IMDB_Puanı"].ToString();
                    lblvizyontarihi.Text = oku["Film_VizyonTarihi"].ToString();
                    lbldurum.Text = oku["Film_Durumu"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
