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
    public partial class YonetmenlerListesi : UserControl
    {
        public YonetmenlerListesi()
        {
            InitializeComponent();
        }
        // Sql bağlantısı için gerekli olan bağlantı dizesi.
        SqlConnection connection = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");
        private void YonetmenlerListesi_Load(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı kapalı ise açar.
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                // Yönetmenler tablosundan tüm kayıtları çeker.
                string sorgu = "select * from Tbl_Yonetmenler where ID = @p1";
                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@p1", lblID.Text);
                SqlDataReader oku = command.ExecuteReader();
                if (oku.Read())
                {
                    lblCinsiyet.Text = oku["Cinsiyet"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                // Bağlantı açık ise kapatır.
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }       
        private void btndetay_Click(object sender, EventArgs e)
        {
            //yönetmen detaylarını gösterme işlemi için gerekli olan kod bloğu.
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string sorgu = "select * from Tbl_Yonetmenler where ID = @p1";// Yönetmenler tablosundan ID'ye göre kayıt çeker.
                SqlCommand command = new SqlCommand(sorgu, connection);
                command.Parameters.AddWithValue("@p1", lblID.Text);
                SqlDataReader oku = command.ExecuteReader();
                if (oku.Read())
                {
                    // Yönetmen bilgilerini gösterir.
                    MessageBox.Show("BİYOGRAFİ: " + oku["Biyografi"].ToString(), oku["AdSoyad"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                // Bağlantı açık ise kapatır.
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            // Yönetmen silme işlemi için gerekli olan kod bloğu.
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand sil = new SqlCommand("delete from Tbl_Yonetmenler where ID = @p1", connection);
                sil.Parameters.AddWithValue("@p1", lblID.Text);
                sil.ExecuteNonQuery();
                this.Hide();
                MessageBox.Show(lblAdSoyad.Text + " ADLI YÖNETMEN KAYDI BAŞARILI BİR ŞEKİLDE SİLİNMİŞTİR.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                // Bağlantı açık ise kapatır.
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
