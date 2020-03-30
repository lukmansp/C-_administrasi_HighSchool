using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adminsmajatra
{
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void pembayaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pembayaran bayar = new pembayaran();
            bayar.Show();
           
        }

        private void dataSiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datasiswa ds = new datasiswa();
            ds.Show();
        }

        private void penambahanBiayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tambahbiaya pen = new tambahbiaya();
            pen.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ubahSandiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cekdata cd = new cekdata();
            cd.Show();
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {

        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
