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
    public partial class datasiswa : Form
    {
        public datasiswa()
        {
            InitializeComponent();
        }
        public void hitung()
        {
            try
            {
                int A, B, C, D, E, F, hasil1;
                A = Convert.ToInt32(textBox5.Text);
                B = Convert.ToInt32(textBox6.Text);
                C = Convert.ToInt32(textBox7.Text);
                D = Convert.ToInt32(textBox8.Text);
                E = Convert.ToInt32(textBox9.Text);
                F = Convert.ToInt32(textBox11.Text);
                hasil1 = (A + B) + (C + D) + (E + F);
                textBox12.Text = Convert.ToString(hasil1);
            }
            catch(Exception MAN)
            {
                MessageBox.Show(MAN.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hitung();
        }
public void dv()
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            textBox8.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            textBox11.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
            textBox12.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            muncul();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            baca();
        }
        public DataTable baca()
        {
            koneksi conn = new koneksi();
            string sql = "select  * from siswa where nis='" + this.textBox14.Text + "'";
            DataTable dt = new DataTable();

            try
            {
                conn.tampil();
                MySqlCommand cmd = new MySqlCommand(sql, conn.konek);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
               
                
            }
            catch (Exception luk)
            {
                MessageBox.Show(luk.Message);
            }
            conn.tutup();
            return dt;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try {
                koneksi conn = new koneksi();
                conn.tampil();
                conn.QUERY("insert into siswa (nis,nama,alamat,jenkel,kelas,kek_thn_lalu,daftar_ulang,spp1,spp2,spp3,sardik,lks,lainlain1,lainlain2,jumlah,keterangan) values ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text +
                    "','" + this.comboBox3.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.textBox7.Text + "','" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.textBox10.Text +
                    "','" + this.textBox11.Text + "','" + this.textBox12.Text + "','" + this.dateTimePicker1.Text + "')");
            }
catch(Exception luki)
            {
                MessageBox.Show(luki.Message);
            }            
            }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult di = MessageBox.Show("Edit Data?", "important", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (di == DialogResult.Yes)
                {

                    koneksi conn = new koneksi();
                    conn.tampil();
                    conn.QUERY("update siswa set nama='" + this.textBox2.Text + "',alamat='" + textBox3.Text + "',jenkel='" + textBox4.Text + "',kelas='" + comboBox3.Text + "',kek_thn_lalu='" + textBox5.Text + "',daftar_ulang='" + textBox6.Text + "',spp1='" + comboBox1.Text + "',spp2='" + comboBox2.Text + "',spp3='" + textBox7.Text + "',sardik='" + textBox8.Text + "',lks='" + textBox9.Text + "',lainlain1='" + textBox10.Text +
                        "',lainlain2='" + textBox11.Text + "',jumlah='" + textBox12.Text + "',keterangan='" + dateTimePicker1.Text + "'where nis='" + textBox1.Text + "'");
                    conn.tutup();


                }
                else if (di == DialogResult.No)
                {

                }
            }
            catch(Exception kur)
            {
                MessageBox.Show(kur.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dv();
        }
        public void muncul()
        {
            button2.Enabled = false;   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            button2.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult di = MessageBox.Show("Hapus Data?","important", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (di == DialogResult.Yes)
            {
                try
                {
                    koneksi conn = new koneksi();
                    conn.tampil();
                    conn.QUERY("delete from siswa where nis='" + this.textBox14.Text + "'");
                    
                    MessageBox.Show("DIHAPUS");
                    conn.tutup();
                  
                }
                catch (Exception lul)
                {
                    MessageBox.Show(lul.Message);
                }
            }
            else if(di==DialogResult.No)
            {
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
                dataGridView1.DataSource = dt;


            }
            catch (Exception luk)
            {
                MessageBox.Show(luk.Message);
            }
            conn.tutup();
            return dt;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            baca2();
        }

        private void datasiswa_Load(object sender, EventArgs e)
        {

        }
    }
}
