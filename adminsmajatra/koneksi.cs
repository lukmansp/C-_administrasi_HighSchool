using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace adminsmajatra
{
    public class koneksi
    {
        String database = "server = localhost; uid=root;pwd='';database=smajatra;";
        public MySqlConnection konek;
        public void tampil()
        {
            konek = new MySqlConnection(database);
            konek.Open();
        }
        public void tutup()
        {
            konek = new MySqlConnection(database);
            konek.Close();
        }
        public void QUERY(string query)
        {
            konek = new MySqlConnection(database);
            MySqlCommand cmd;
            try
            {
                konek.Open();
                cmd = new MySqlCommand(query, konek);
                cmd.ExecuteNonQuery();
                MessageBox.Show("SUKSES");
            }
            catch (Exception ali)
            {
                MessageBox.Show(ali.Message);
            }
            finally
            {
                konek.Close();
            }
        }
    }


}

