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

        private void add_client_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label5.Visible)
                label5.Visible = false;

            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text))
            {

                MySqlCommand command = new MySqlCommand("INSERT INTO Client (name, birth, polis) VALUES (@name, @birth, @polis)", connection);

                command.Parameters.AddWithValue("name", textBox2.Text);

                command.Parameters.AddWithValue("birth", textBox3.Text);

                command.Parameters.AddWithValue("polis", textBox4.Text);

                command.ExecuteNonQuery();
                this.CloseConnection();

            }
            else
            {
                label5.Visible = true;

                label5.Text = "Поля данных не заполнены!";
            }

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


        private void change_client_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label6.Visible)
                label6.Visible = false;

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MySqlCommand command = new MySqlCommand("UPDATE Client SET name=@name, birth=@birth, polis=@polis WHERE id_client=@id_client", connection);

                command.Parameters.AddWithValue("id_client", textBox1.Text);
                command.Parameters.AddWithValue("name", textBox2.Text);
                command.Parameters.AddWithValue("birth", textBox3.Text);
                command.Parameters.AddWithValue("polis", textBox4.Text);

                command.ExecuteNonQuery();
                this.CloseConnection();

            }
            else if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                label6.Visible = true;
                label6.Text = "Заполните все поля для изменения";

            }

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

        private void delete_client_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label7.Visible)
                label7.Visible = false;

            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM Client WHERE id_client=@id_client", connection);

                command.Parameters.AddWithValue("id_client", textBox1.Text);

                command.ExecuteNonQuery();
                this.CloseConnection();

            }
            else
            {
                label7.Visible = true;
                label7.Text = "Заполните поле id_client для удаления";
            }
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
    }
}

