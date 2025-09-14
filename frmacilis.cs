using System.Data;
using Microsoft.Data.SqlClient; // Microsoft.Data.SqlClient kütüphanesini kullanýyoruz.


namespace RozCineWorld
{
    public partial class Frmacilis : Form
    {
        public Frmacilis()
        {
            InitializeComponent();
        }
        //sqlconnection nesnesi oluþturuz.
        SqlConnection connection = new SqlConnection("Server= localhost;Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True;TrustServerCertificate=true;");
        private void btnkapat_Click(object sender, EventArgs e)// Kapatma butonuna týklandýðýnda çalýþacak kod
        {
            Application.Exit();
        }
        // Form yüklendiðinde çalýþacak kod
        private void btngiris_Click(object sender, EventArgs e)
        {
            try
            {
                // SqlConnection nesnesi ile veritabanýna baðlantý açýlýr.
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                // Kullanýcý adý ve þifre ile veritabanýnda sorgu yapýlýr.
                SqlCommand command = new SqlCommand("SELECT * FROM Tbl_kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre", connection);
                command.Parameters.AddWithValue("@KullaniciAdi", txtkullaniciadi.Text);
                command.Parameters.AddWithValue("@Sifre", txtsifre.Text);
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())// Eðer kullanýcý adý ve þifre doðruysa
                {
                    // Ana formu açar ve kullanýcý adýný gösterir.
                    // FrmAnaForm sýnýfý, ana formun tasarýmýný içerir.
                    FrmAnaForm frmAnaForm = new FrmAnaForm();
                    frmAnaForm.kisiAdSoyad = Reader["AdSoyad"]?.ToString()??"AdSoyad alaný boþ";
                    frmAnaForm.Show();
                    this.Hide();
                }
                else// Eðer kullanýcý adý ve þifre yanlýþsa hatta mesajý gösterir.
                {
                    Frmhata frm = new Frmhata();
                    frm.lblhatamesaji.Text ="KULLANICI KAYDI BULUNAMADI! KULLANICI ADI YA DA ÞÝFRE HATALI!";
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)// Eðer bir hata oluþursa mesaj kutusunda gösterir.
            {
                Frmhata frm = new Frmhata();
                frm.lblhatamesaji.Text = ex.Message;
                frm.ShowDialog();
            }
            finally// Baðlantý kapatýlýr ve kullanýcý adý ve þifre alanlarý temizlenir.
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
