using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // SQL Server veritabanı işlemleri için gerekli kütüphane

namespace RozCineWorld
{
    public partial class FrmBiletSorgulama : Form
    {
        public FrmBiletSorgulama()
        {
            InitializeComponent();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close(); // Kapatma butonuna tıklandığında formu kapatır.
        }
        SqlConnection connection = new SqlConnection("Server= localhost;Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True;TrustServerCertificate=true;");
        private void BtnSorgula_Click(object sender, EventArgs e)
        {
            if (txtBiletNo.Text != "")
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand command = new SqlCommand("select * from Tbl_Biletler WHERE BKOD = @kod", connection);
                    command.Parameters.AddWithValue("@kod", txtBiletNo.Text.ToString()); // Bilet numarasını parametre olarak ekler.
                    SqlDataReader oku = command.ExecuteReader(); // Sorguyu çalıştırır ve verileri okur.
                    if (oku.Read())
                    {
                        FrmBiletDetay frm = new FrmBiletDetay();
                        frm.biletNo = txtBiletNo.Text; // Bilet numarasını FrmBiletDetay formuna aktarır.
                        frm.ShowDialog(); // FrmBiletDetay formunu gösterir.
                    }
                    else
                    {
                        MessageBox.Show("KAYITLI BİLET BULUNAMADI!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN BİLET NUMARASI GİRİNİZ!");
            }
        }
    }
}
