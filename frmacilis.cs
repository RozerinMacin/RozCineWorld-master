using System.Data;
using System.Data.SqlClient;
    
namespace RozCineWorld
{
    public partial class frmacilis : Form
    {
        public frmacilis()
        {
            InitializeComponent();
        }
        
        SqlConnection connection = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");
   
        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Tbl_kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre",connection);
            command.Parameters.AddWithValue("@KullaniciAdi",txtkullaniciadi.Text);
            command.Parameters.AddWithValue("@Sifre", txtsifre.Text);
            SqlDataReader Reader = command.ExecuteReader();
            if (Reader.Read())
            {
                FrmAnaForm frmAnaForm = new FrmAnaForm();
                frmAnaForm.kisiAdSoyad = Reader["AdSoyad"].ToString();
                frmAnaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("KULLANICI KAYDI BULUNAMADI! KULLANICI ADI YA DA ÞÝFRE HATALI!");
            }
            connection.Close();

            txtkullaniciadi.Text = "";
            txtsifre.Text = "";
            txtkullaniciadi.Focus();         
        }
    }
}
