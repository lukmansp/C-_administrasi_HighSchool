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
using MySql.Data.MySqlClient;
namespace adminsmajatra
{
    public partial class pembayaran : Form
    {
        public MySqlDataReader rdr;

        public pembayaran()
        {
            InitializeComponent();
        }

        private void pembayaran_Load(object sender, EventArgs e)
        {

        }
 public DataTable baca()
        {
            koneksi conn = new koneksi();
            string sql = "select  * from siswa where nis='"+this.textBox16.Text+"'";
            DataTable dt = new DataTable();
          
                try
                {
                    conn.tampil();
                    MySqlCommand cmd = new MySqlCommand(sql, conn.konek);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
               
                    cmd.ExecuteNonQuery();
                    adp.Fill(dt);
                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;

            }
            catch (Exception luk)
            {
                MessageBox.Show(luk.Message);
            }
            conn.tutup();
            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
          baca();
            

        }
       
       public void dv()
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                kekurangan.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                d_ulang.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                textBox9.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                spp.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                sardik.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                lks.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                textBox13.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                lainlain.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                total.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
                textBox17.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            }
            catch(Exception LUKH)
            {
                MessageBox.Show(LUKH.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dv();
        }
        public void hitung()
        {
            try
            {
                int L, M, hasil;
                L = Convert.ToInt32(kekurangan.Text);
                M = Convert.ToInt32(kekurangan1.Text);
                hasil = L - M;
                kekurangan2.Text = Convert.ToString(hasil);
                int A, B, hasil1;
                A = Convert.ToInt32(d_ulang.Text);
                B = Convert.ToInt32(d_ulang1.Text);
                hasil1 = A - B;
                d_ulang2.Text = Convert.ToString(hasil1);
                int D, E, hasil2;
                D = Convert.ToInt32(spp.Text);
                E = Convert.ToInt32(spp1.Text);
                hasil2 = D - E;
                spp2.Text = Convert.ToString(hasil2);
                int F, G, hasil3;
                F = Convert.ToInt32(sardik.Text);
                G = Convert.ToInt32(sardik1.Text);
                hasil3 = F - G;
                sardik2.Text = Convert.ToString(hasil3);
                int H, I, hasil4;
                H = Convert.ToInt32(lks.Text);
                I = Convert.ToInt32(lks1.Text);
                hasil4 = H - I;
                lks2.Text = Convert.ToString(hasil4);
                int J, K, hasil5, total1;
                J = Convert.ToInt32(lainlain.Text);
                K = Convert.ToInt32(lainlain1.Text);
                hasil5 = J - K;
                lainlain2.Text = Convert.ToString(hasil5);
                total1 = (hasil + hasil1) + (hasil2 + hasil3) + (hasil4 + hasil5);
                jumlah.Text = Convert.ToString(total1);
            }
            catch(Exception lukis)
            {
                MessageBox.Show(lukis.Message);
            }
            }
        private void button2_Click(object sender, EventArgs e)
        {
            hitung();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi conn = new koneksi();
                conn.tampil();
                conn.QUERY("update siswa set nama='" + this.textBox2.Text + "',alamat='" + textBox3.Text + "',jenkel='" + textBox4.Text + "',kelas='" + textBox5.Text + "',kek_thn_lalu='" + kekurangan2.Text + "',daftar_ulang='" + d_ulang2.Text + "',spp1='" + comboBox1.Text + "',spp2='" + comboBox2.Text + "',spp3='" + spp2.Text +
                    "',sardik='" + sardik2.Text + "',lks='" + lks2.Text + "',lainlain1='" + textBox22.Text + "',lainlain2='" + lainlain2.Text + "',jumlah='" + jumlah.Text + "',keterangan='" + dateTimePicker1.Text + "'where nis='" + textBox1.Text + "'");
            }
            catch(Exception les)
            {
                MessageBox.Show(les.Message);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox13.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            kekurangan.Text = "";
            kekurangan1.Text = "";
            kekurangan2.Text = "0";
            d_ulang.Text = "";
            d_ulang1.Text = "";
            d_ulang2.Text = "0";
            spp.Text = "";
            spp1.Text = "";
            spp2.Text = "0";
            comboBox1.Text = "";
            comboBox2.Text = "";
           
            sardik.Text = "";
            sardik1.Text = "";
            sardik2.Text = "0";
            lks.Text = "";
            lks1.Text = "";
            lks2.Text = "0";
            lainlain.Text = "";
            lainlain1.Text = "";
            lainlain2.Text = "0";
            textBox22.Text = "";
            total.Text = "";
            jumlah.Text = "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public DataTable baca2()
        {
            koneksi conn = new koneksi();
            string sql = "select  * from siswa where kelas='" + this.comboBox4.Text + "'";
            DataTable dt = new DataTable();

            try
            {
                conn.tampil();
                MySqlCommand cmd = new MySqlCommand(sql, conn.konek);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
                bindingSource1.DataSource = dt;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;


            }
            catch (Exception luk)
            {
                MessageBox.Show(luk.Message);
            }
            conn.tutup();
            return dt;
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            baca2();  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printDocument1.PrinterSettings.DefaultPageSettings.Landscape = false;
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var font = new Font("khmer UI", 12);
            e.Graphics.DrawString("\t\t\t BUKTI PEMBAYARAN SMA MA'ARIF NU JATINEGARA \n\n\n", font, Brushes.Black, 25, 10);
            e.Graphics.DrawString("Nis               \t: " + textBox1.Text + "\n\n", font, Brushes.Black, 20, 30);
            e.Graphics.DrawString("Nama              \t: " + textBox2.Text + "\n\n", font, Brushes.Black, 20, 50);
            e.Graphics.DrawString("Alamat            \t: " + textBox3.Text + "\n\n", font, Brushes.Black, 20, 70);
            e.Graphics.DrawString("Jenkel            \t: " + textBox4.Text + "\n\n", font, Brushes.Black, 20, 90);
            e.Graphics.DrawString("Kelas             \t: " + textBox5.Text + "\n\n", font, Brushes.Black, 20, 110);
            e.Graphics.DrawString("Kek_Tahun lalu    \t: " + kekurangan.Text + "\n\n", font, Brushes.Black, 20, 150);
            e.Graphics.DrawString("Daftar Ulang      \t: " + d_ulang.Text + "\n\n", font, Brushes.Black, 20, 170);
            e.Graphics.DrawString("Spp               \t: " + textBox8.Text+" - "+textBox9.Text  + "\n\n", font, Brushes.Black, 20, 190);
            e.Graphics.DrawString("           Jumlah \t: " + spp.Text + "\n\n", font, Brushes.Black, 20, 210);
            e.Graphics.DrawString("Sardik            \t: " + sardik.Text + "\n\n", font, Brushes.Black, 20, 230);
            e.Graphics.DrawString("LKS               \t: " + lks.Text + "\n\n", font, Brushes.Black, 20, 250);
            e.Graphics.DrawString("Lain Lain         \t: " + textBox13.Text+" = "+lainlain.Text + "\n\n", font, Brushes.Black, 20, 270);
            e.Graphics.DrawString("Total             \t: " + total.Text + "\n\n", font, Brushes.Black, 20, 290);
            e.Graphics.DrawString("Tanggal Pembayaran\t: " + textBox17.Text + "\n\n", font, Brushes.Black, 20, 310);


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
