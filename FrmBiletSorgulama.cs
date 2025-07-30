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

        private void BtnSorgula_Click(object sender, EventArgs e)
        {
            FrmBiletDetay frm = new FrmBiletDetay();
            frm.biletNo = txtBiletNo.Text; // Bilet numarasını FrmBiletDetay formuna aktarır.
            frm.ShowDialog(); // FrmBiletDetay formunu gösterir.
        }
    }
}
