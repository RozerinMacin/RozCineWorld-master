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

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string kisiAdSoyad = "";

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            label2.Text = ("İşlemi Gerçekleştirecek Olan Yetkili Kişi = " + kisiAdSoyad);
        }

        private void btnyonetmenkayit_Click(object sender, EventArgs e)
        {
            FrmYonetmenkayit frm = new FrmYonetmenkayit();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmYonetmenListesi frm = new FrmYonetmenListesi();
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmOyuncuKayit frm = new FrmOyuncuKayit();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOyuncuListesi Frm = new FrmOyuncuListesi();
            Frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSalonKayit frm = new FrmSalonKayit();
            frm.ShowDialog();
        }
    }
}
