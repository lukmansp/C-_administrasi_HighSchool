using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    public partial class cekdata : Form
    {
        public cekdata()
        {
            InitializeComponent();
        }
        public MySqlDataAdapter adp;
        public MySqlDataReader rdr;
        Bitmap memoryImage;
      
        private void cekdata_Load(object sender, EventArgs e)
        {

        }
        private void CaptureScreen()
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

     
       
        private void button1_Click(object sender, EventArgs e)
        {
            baca();
        }
        public DataTable baca()
        {
            koneksi conn = new koneksi();
            string sql = "select  * from siswa where nis='" + this.textBox16.Text + "'";
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
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            baca2();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baca();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           

            
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 10, 10);
           
        }

       
    } 
}
