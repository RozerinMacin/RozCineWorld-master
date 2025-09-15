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
using Microsoft.Identity.Client;

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
                string sorgu = "select * from Tbl_Filmler where ID = @id";// Film detaylarını çekmek için kullanılacak SQL sorgusu
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@id", IdNo);
                SqlDataReader oku = command.ExecuteReader();
                if (oku.Read())// Okunan veriler ile form üzerindeki kontroller doldurulacak
                {
                    lblFilmAdi.Text = oku["Film_Adi"].ToString();
                    pBResim.ImageLocation = oku["Film_Afisi"].ToString();
                    lblyonetmen.Text = oku["Film_Yonetmeni"].ToString();
                    lbloyuncu.Text = oku["Film_Oyuncuları"].ToString();
                    lbltur.Text = oku["Film_Türü"].ToString();
                    lblozellikler.Text = oku["Film_Ozellikleri"].ToString();
                    lblbicim.Text = oku["Film_Bicimi"].ToString();
                    lbldetay.Text = oku["Film_Detayi"].ToString();
                    lblIMDB.Text = oku["Film_IMDB_Puanı"].ToString();
                    lblvizyontarihi.Text = oku["Film_VizyonTarihi"].ToString();
                    lbldurum.Text = oku["Film_Durumu"].ToString();
                }
                oku.Close();
                DateTime dVTarih = Convert.ToDateTime(lblvizyontarihi.Text);// Vizyon tarihini DateTime tipine dönüştür
                DateTime bugun = DateTime.Today;// Bugünün tarihini almak için DateTime.Today kullanılır
                TimeSpan tspan = dVTarih - bugun;// Vizyon tarihi ile bugünün tarihi arasındaki farkı hesapla
                int gun = Math.Abs(tspan.Days);// Gün sayısını al ve negatif değerleri pozitif yap
                if (lbldurum.Text == "1")//vizyon tarihi hesaplama işlemlerini bu kod bloğunda gerçekleştiriyoruz.
                {
                    if (tspan.TotalDays < 0)
                    {
                        lbldurum.Text = (gun + " gün önce vizyona girdi.");
                    }
                    else if (tspan.TotalDays == 0)
                    {
                        lbldurum.Text = "film bugün vizyona girdi.";
                    }
                }
                else if (lbldurum.Text == "0")
                {
                    if (DateTime.Parse(lblvizyontarihi.Text) > DateTime.Now)
                    {
                        lbldurum.Text = (tspan.Days + " gün sonra vizyona girecek.");
                    }
                }
            }
            catch (Exception ex)
            {
                Frmhata frm = new Frmhata();
                frm.lblhatamesaji.Text = ex.Message;
                frm.ShowDialog();
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
