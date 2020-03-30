using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace adminsmajatra
{
    public class tampil
    {
        public DataTable baca()
        {
            koneksi conn = new koneksi();
            string sql = "select * from siswa";
            DataTable dt = new DataTable();
            try
            {
                conn.tampil();
                MySqlCommand cmd = new MySqlCommand(sql, conn.konek);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.tutup();
            return dt;
        }

    }
}

