using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace kursach2
{
    public partial class Form1 : Form
    {

        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;


        public Form1()
        {
            InitializeComponent();
            load_data();
        }

        private void load_data()
        {
            server = "silan.zyns.com";
            database = "cyvarev";
            uid = "cyvarev";
            password = "cyvarev";
            
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
         

            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("select * from Client", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

                
                this.CloseConnection();
            }

        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
               
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
