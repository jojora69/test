using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace test
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void log_button_Click(object sender, EventArgs e)
        {
            if (logBox.Text != "admin" && passBox.Text != "0000")
            {
                string query = "SELECT login FROM users WHERE login = '" + logBox.Text + "' AND pass = '" + passBox.Text + "';";
                MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["testDB"].ConnectionString);
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();

                adapter.SelectCommand = cmDB;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    user uForm1 = new user();
                    uForm1.Show();
                }
                else
                    MessageBox.Show("Неправильный логин или пароль.");

            }
            else 
            {
                this.Hide();
                Form1 mainForm1 = new Form1();
                mainForm1.Show();
            }

            
        }

        public Boolean isUserExists()
        {
            string role = "SELECT role FROM users";
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["testDB"].ConnectionString);
            MySqlCommand cmDB = new MySqlCommand(role, conn);

            adapter.SelectCommand = cmDB;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                if (role == "admin")
                {
                    Form1 aWin = new Form1();
                    aWin.Show();
                    this.Hide();
                }
                else if (role == "user")
                {
                    user uWin = new user();
                    uWin.Show();
                    this.Hide();
                }
                return true;
            }

            else
                return false;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
