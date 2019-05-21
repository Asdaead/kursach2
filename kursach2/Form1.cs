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

        private string  server = "silan.zyns.com";
        private string database = "cyvarev";
        private string uid = "cyvarev";
        private string password = "cyvarev";
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;
        

        public Form1()
        {
            InitializeComponent();

            load_data();
        }

        private void load_data()
        {
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

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                id_box.Text = row.Cells[0].Value.ToString();
                name_box.Text = row.Cells[1].Value.ToString();
                birth_box.Text = row.Cells[2].Value.ToString();
                polis_box.Text = row.Cells[3].Value.ToString();
            }
        }

        private void add_client_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label5.Visible)
                label5.Visible = false;

            if (!string.IsNullOrEmpty(name_box.Text) && !string.IsNullOrWhiteSpace(name_box.Text) &&
                !string.IsNullOrEmpty(birth_box.Text) && !string.IsNullOrWhiteSpace(birth_box.Text) &&
                !string.IsNullOrEmpty(polis_box.Text) && !string.IsNullOrWhiteSpace(polis_box.Text))
            {

                MySqlCommand command = new MySqlCommand("INSERT INTO Client (name, birth, polis) VALUES (@name, @birth, @polis)", connection);

                command.Parameters.AddWithValue("name", name_box.Text);

                command.Parameters.AddWithValue("birth", datepick.Value);

                command.Parameters.AddWithValue("polis", polis_box.Text);

                command.ExecuteNonQuery();
                this.CloseConnection();

            }
            else
            {
                label5.Visible = true;

                label5.Text = "Поля данных не заполнены!";
            }

            load_data();


        }


        private void change_client_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label5.Visible)
                label5.Visible = false;

            if (!string.IsNullOrEmpty(id_box.Text) && !string.IsNullOrWhiteSpace(id_box.Text) &&
                !string.IsNullOrEmpty(name_box.Text) && !string.IsNullOrWhiteSpace(name_box.Text) &&
                !string.IsNullOrEmpty(birth_box.Text) && !string.IsNullOrWhiteSpace(birth_box.Text) &&
                !string.IsNullOrEmpty(polis_box.Text) && !string.IsNullOrWhiteSpace(polis_box.Text))
            {
                MySqlCommand command = new MySqlCommand("UPDATE Client SET name=@name, birth=@birth, polis=@polis WHERE id_client=@id_client", connection);

                command.Parameters.AddWithValue("id_client", id_box.Text);
                command.Parameters.AddWithValue("name", name_box.Text);
                command.Parameters.AddWithValue("birth", datepick.Value);
                command.Parameters.AddWithValue("polis", polis_box.Text);

                command.ExecuteNonQuery();
                this.CloseConnection();

            }
            else if (!string.IsNullOrEmpty(id_box.Text) && !string.IsNullOrWhiteSpace(id_box.Text))
            {
                label5.Visible = true;
                label5.Text = "Заполните все поля для изменения";

            }

            load_data();

        }

        private void delete_client_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label5.Visible)
                label5.Visible = false;

            if (!string.IsNullOrEmpty(id_box.Text) && !string.IsNullOrWhiteSpace(id_box.Text))
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM Client WHERE id_client=@id_client", connection);

                command.Parameters.AddWithValue("id_client", id_box.Text);

                command.ExecuteNonQuery();
                this.CloseConnection();

            }
            else
            {
                label5.Visible = true;
                label5.Text = "Заполните поле id_client для удаления";
            }
            load_data();
        }
        }
    }


