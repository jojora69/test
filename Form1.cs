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
using System.Configuration;
using MySql.Data.MySqlClient;

namespace test
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["testDB"].ConnectionString);

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("+");
            }

            conn.Close();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO sotrudniki ( name, address, tel) VALUES (N'{nameBox.Text}', N'{adresBox.Text}', N'{telBox.Text}')";
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["testDB"].ConnectionString);
            MySqlCommand cmDB = new MySqlCommand( query, conn);
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                MessageBox.Show("Успешно");
                nameBox.Clear();
                adresBox.Clear();
                telBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неудачно");
                MessageBox.Show(ex.Message);
            }
        }

        private void selectbutton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["testDB"].ConnectionString);
            MySqlDataAdapter msad = new MySqlDataAdapter("select * from sotrudniki", conn);

            DataSet dataSet = new DataSet();

            msad.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"name LIKE '%{searchBox.Text}%'";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:

                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"address = 'New York'";

                    break;

                case 1:

                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"address = 'Москва'";

                    break;

                case 2:

                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"address = 'California'";

                    break;

                case 3:

                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";

                    break;
            }
        }
    }
}
