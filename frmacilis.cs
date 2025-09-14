using System.Data;
using Microsoft.Data.SqlClient; // Microsoft.Data.SqlClient k�t�phanesini kullan�yoruz.


namespace RozCineWorld
{
    public partial class Frmacilis : Form
    {
        public Frmacilis()
        {
            InitializeComponent();
        }
        //sqlconnection nesnesi olu�turuz.
        SqlConnection connection = new SqlConnection("Server= localhost;Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True;TrustServerCertificate=true;");
        private void btnkapat_Click(object sender, EventArgs e)// Kapatma butonuna t�kland���nda �al��acak kod
        {
            Application.Exit();
        }
        // Form y�klendi�inde �al��acak kod
        private void btngiris_Click(object sender, EventArgs e)
        {
            try
            {
                // SqlConnection nesnesi ile veritaban�na ba�lant� a��l�r.
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                // Kullan�c� ad� ve �ifre ile veritaban�nda sorgu yap�l�r.
                SqlCommand command = new SqlCommand("SELECT * FROM Tbl_kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre", connection);
                command.Parameters.AddWithValue("@KullaniciAdi", txtkullaniciadi.Text);
                command.Parameters.AddWithValue("@Sifre", txtsifre.Text);
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())// E�er kullan�c� ad� ve �ifre do�ruysa
                {
                    // Ana formu a�ar ve kullan�c� ad�n� g�sterir.
                    // FrmAnaForm s�n�f�, ana formun tasar�m�n� i�erir.
                    FrmAnaForm frmAnaForm = new FrmAnaForm();
                    frmAnaForm.kisiAdSoyad = Reader["AdSoyad"]?.ToString()??"AdSoyad alan� bo�";
                    frmAnaForm.Show();
                    this.Hide();
                }
                else// E�er kullan�c� ad� ve �ifre yanl��sa hatta mesaj� g�sterir.
                {
                    Frmhata frm = new Frmhata();
                    frm.lblhatamesaji.Text ="KULLANICI KAYDI BULUNAMADI! KULLANICI ADI YA DA ��FRE HATALI!";
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)// E�er bir hata olu�ursa mesaj kutusunda g�sterir.
            {
                Frmhata frm = new Frmhata();
                frm.lblhatamesaji.Text = ex.Message;
                frm.ShowDialog();
            }
            finally// Ba�lant� kapat�l�r ve kullan�c� ad� ve �ifre alanlar� temizlenir.
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                txtkullaniciadi.Text = "";
                txtsifre.Text = "";
                txtkullaniciadi.Focus();
            }       
        }
    }
}
