using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozCineWorld
{
    public partial class OyuncuListesi : UserControl
    {
        public OyuncuListesi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");
        private void OyuncuListesi_Load(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                string sorgu = "SELECT * FROM Tbl_Oyuncular WHERE ID=@p1";
                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@p1", lblID.Text);
                SqlDataReader oku = command.ExecuteReader();
                if (oku.Read()) lblCinsiyet.Text = oku["Cinsiyet"].ToString();
                oku.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgi getirilirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        private void btndetay_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                string sorgu = "SELECT * FROM Tbl_Oyuncular WHERE ID = @p1";
                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@p1", lblID.Text);
                SqlDataReader oku = command.ExecuteReader();
                if (oku.Read())
                {
                    MessageBox.Show("BİYOGRAFİ: " + oku["Biyografi"].ToString(), oku["AdSoyad"].ToString());
                }
                oku.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgi getirilirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand sil = new SqlCommand("DELETE FROM Tbl_Oyuncular WHERE ID = @p1", connection);
                sil.Parameters.AddWithValue("@p1", lblID.Text);
                sil.ExecuteNonQuery();
                this.Hide();
                MessageBox.Show(lblAdSoyad.Text + " ADLI OYUNCU KAYDI BAŞARILI BİR ŞEKİLDE SİLİNMİŞTİR.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt silinirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
