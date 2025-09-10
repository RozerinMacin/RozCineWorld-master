using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozCineWorld
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void btnkapat_Click(object sender, EventArgs e)// Kapatma butonuna tıklandığında çalışacak kod bütün programı kapatır.
        {
            Application.Exit();
        }
        // Bu form yüklendiğinde çalışacak kod
        public string kisiAdSoyad = "";
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde, label2 kontrolüne yetkili kişinin adını ve soyadını atar.
            label2.Text = ("İşlemi Gerçekleştirecek Olan Yetkili Kişi = " + kisiAdSoyad);
        }

        private void btnyonetmenkayit_Click(object sender, EventArgs e)
        {
            // Yönetmen kayıt formunu açar.
            FrmYonetmenkayit frm = new FrmYonetmenkayit();
            frm.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Yönetmen listesi formunu açar.
            FrmYonetmenListesi frm = new FrmYonetmenListesi();
            frm.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Oyuncu kayıt formunu açar.
            FrmOyuncuKayit frm = new FrmOyuncuKayit();
            frm.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Oyuncu listesi formunu açar.
            FrmOyuncuListesi Frm = new FrmOyuncuListesi();
            Frm.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Salon kayıt formunu açar.
            FrmSalonKayit frm = new FrmSalonKayit();
            frm.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Salon listesi formunu açar.
            Frm_FilmKayit frm = new Frm_FilmKayit();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Film listesi formunu açar.
            FrmFilmListe frm = new FrmFilmListe();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Salon atama ekranını açar.
            frmSalonAtama frm = new frmSalonAtama();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Bilet oluşturma formunu açar.
            FrmBiletOlusturma frm = new FrmBiletOlusturma();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Bilet sorgulama formunu açar.
            FrmBiletSorgulama frm = new FrmBiletSorgulama();
            frm.ShowDialog();
        }
    }
}
