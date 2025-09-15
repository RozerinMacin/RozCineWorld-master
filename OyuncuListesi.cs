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
    public partial class OyuncuListesi : UserControl
    {
        public OyuncuListesi()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Server= localhost;Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True;TrustServerCertificate=true;");
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
                Frmhata frm = new Frmhata();
                frm.lblhatamesaji.Text ="Bilgi getirilirken hata oluştu:\n" +  ex.Message;
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
                    Frmhata frm = new Frmhata();
                    frm.lblhatamesaji.Text = "BİYOGRAFİ: " + oku["Biyografi"].ToString();
                    frm.lblhatamesaji.MaximumSize = new Size(0, 0);
                    frm.lblhatamesaji.TextAlign = ContentAlignment.MiddleCenter;  // Ortala
                    frm.lblhatamesaji.Dock = DockStyle.Fill;                      // Tüm formu kaplasın
                    frm.AutoSize = false;
                    frm.lblhata.Text =  oku["AdSoyad"].ToString();
                    frm.pbMESAJ.Image =null;
                    frm.btntamam.Visible = false;
                    frm.Size = new Size(450, 220);
                    frm.ShowDialog();
                }
                oku.Close();
            }
            catch (Exception ex)
            {
                Frmhata frm = new Frmhata();
                frm.lblhatamesaji.Text ="Bilgi getirilirken hata oluştu:\n" +  ex.Message;
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
                Frmhata frm = new Frmhata();
                frm.lblhatamesaji.Text = lblAdSoyad.Text + " ADLI OYUNCU KAYDI BAŞARILI BİR ŞEKİLDE SİLİNMİŞTİR.";
                frm.lblhata.Text = "BAŞARILI";
                frm.pbMESAJ.Image = (System.Drawing.Image)(Properties.Resources.tik);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Frmhata frm = new Frmhata();
                frm.lblhatamesaji.Text ="Kayıt silinirken hata oluştu:\n" +  ex.Message;
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
    }
}
