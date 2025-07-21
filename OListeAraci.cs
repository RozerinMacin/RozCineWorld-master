using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RozCineWorld
{
    public partial class OListeAraci : UserControl
    {
        public OListeAraci()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog =RozCineWorldVT;Integrated Security =True");
        private void lbladi_Click(object sender, EventArgs e)
        {
            if (lbladi.ForeColor == Color.FromArgb(16, 46, 80))
            {
                lbladi.ForeColor = Color.White;
                connection.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Secilenler(Kisi, tur) values(@kisi, @tur)", connection);
                komut.Parameters.AddWithValue("@kisi", lbladi.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");
                komut.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                lbladi.ForeColor = Color.FromArgb(16, 46, 80);
                connection.Open();
                SqlCommand komut = new SqlCommand("delete from Tbl_Secilenler where Kisi = @kisi AND Tur = @tur", connection);
                komut.Parameters.AddWithValue("@kisi", lbladi.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");
                komut.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void lbladi_MouseMove(object sender, MouseEventArgs e)
        {
            lbladi.Font = new Font(lbladi.Font.Name, 10, FontStyle.Underline);
        }

        private void lbladi_MouseLeave(object sender, EventArgs e)
        {
            lbladi.Font = new Font(lbladi.Font.Name, 10, FontStyle.Regular);
        }

        private void OListeAraci_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Secilenler WHERE Kisi =@kisi AND Tur =@tur", connection);
            komut.Parameters.AddWithValue("@kisi", lbladi.Text);
            komut.Parameters.AddWithValue("@tur", "OYUNCU");
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lbladi.ForeColor = Color.White;
            }
            else
            {
                lbladi.ForeColor = Color.FromArgb(16, 46, 80);
            }
            connection.Close();
        }
    }
}
