using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace adminsmajatra
{
    public partial class Form1 : Form
    {
       private string conn;
        private MySqlConnection connect;
        public Form1()
        {
            InitializeComponent();
        }
 
        private void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=smajatra;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
 
        private bool validate_login(string user, string pass)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from login where username=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (nama.Text == "")
            {
                MessageBox.Show("Employee ID Cannot Be Empty");
            }
            else if (password.Text == "")
            {
                MessageBox.Show("Password Cannot Be Empty");
            }
            else
            {
                if (nama.Text != "admin" && password.Text != "admin")
                {
                    MessageBox.Show("Your Login Failed");
                }
                else
                {
                    MessageBox.Show("Succes Login");
                    mainmenu menu = new mainmenu();
                    menu.Show();
                    this.Visible = false;
                }
            }
        }
    }
    }

