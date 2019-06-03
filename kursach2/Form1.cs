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
        private string server = "silan.zyns.com";
        private string database = "cyvarev";
        private string uid = "cyvarev";
        private string password = "cyvarev";
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;
        

        public Form1()
        {
            InitializeComponent();

            load_data_client();
            load_data_doc();
            load_data_item();
            load_data_request();
            load_data_order();
            load_data_service();
        }

        private void load_data_client()
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

        private void load_data_doc()
        {
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);


            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("select * from doctor", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView2.DataSource = DS.Tables[0];
                this.CloseConnection();
            }

        }

        private void load_data_item()
        {
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);


            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("select * from item", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView3.DataSource = DS.Tables[0];
                this.CloseConnection();
            }

        }

        private void load_data_order()
        {
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);


            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("select * from ord", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView4.DataSource = DS.Tables[0];
                this.CloseConnection();
            }

        }

        private void load_data_request()
        {
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);


            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("select * from request", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView5.DataSource = DS.Tables[0];
                this.CloseConnection();
            }

        }

        private void load_data_service()
        {
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);


            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("select * from service", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView6.DataSource = DS.Tables[0];
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

        private void add_client_Click(object sender, EventArgs e)
        {
            
            if (label_client.Visible)
                label_client.Visible = false;

            if (!string.IsNullOrEmpty(name_box.Text) && !string.IsNullOrWhiteSpace(name_box.Text) &&
                datepick.Value != null &&
                !string.IsNullOrEmpty(polis_box.Text) && !string.IsNullOrWhiteSpace(polis_box.Text))

                Database.add_client(name_box.Text, datepick.Value, polis_box.Text);

            else
            {
                label_client.Visible = true;

                label_client.Text = "Поля данных не заполнены!";
            }

            load_data_client();


        }

        private void change_client_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label_client.Visible)
                label_client.Visible = false;

            if (!string.IsNullOrEmpty(id_box.Text) && !string.IsNullOrWhiteSpace(id_box.Text) &&
                !string.IsNullOrEmpty(name_box.Text) && !string.IsNullOrWhiteSpace(name_box.Text) &&
                datepick.Value != null &&
                !string.IsNullOrEmpty(polis_box.Text) && !string.IsNullOrWhiteSpace(polis_box.Text))
                Database.change_client(id_box.Text, name_box.Text, datepick.Value, polis_box.Text);
            else if (!string.IsNullOrEmpty(id_box.Text) && !string.IsNullOrWhiteSpace(id_box.Text))
            {
                label_client.Visible = true;
                label_client.Text = "Заполните все поля для изменения";

            }

            load_data_client();

        }

        private void delete_client_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label_client.Visible)
                label_client.Visible = false;

            if (!string.IsNullOrEmpty(id_box.Text) && !string.IsNullOrWhiteSpace(id_box.Text))
                Database.delete_client(id_box.Text, "client");
            else
            {
                label_client.Visible = true;
                label_client.Text = "Заполните поле id_client для удаления";
            }
            load_data_client();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (label_doc.Visible)
                label_doc.Visible = false;

            if (!string.IsNullOrEmpty(name_doc_tb.Text) && !string.IsNullOrWhiteSpace(name_doc_tb.Text) &&
                !string.IsNullOrEmpty(spec_doc_tb.Text) && !string.IsNullOrWhiteSpace(spec_doc_tb.Text) &&
                !string.IsNullOrEmpty(phone_doc_tb.Text) && !string.IsNullOrWhiteSpace(phone_doc_tb.Text))

                Database.add_doc(name_doc_tb.Text, spec_doc_tb.Text, phone_doc_tb.Text);

            else
            {
                label_doc.Visible = true;

                label_doc.Text = "Поля данных не заполнены!";
            }

            load_data_doc();
        }

        private void Change_doc_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label_doc.Visible)
                label_doc.Visible = false;

            if (!string.IsNullOrEmpty(id_doc_tb.Text) && !string.IsNullOrWhiteSpace(id_doc_tb.Text) &&
                !string.IsNullOrEmpty(name_doc_tb.Text) && !string.IsNullOrWhiteSpace(name_doc_tb.Text) &&
                !string.IsNullOrEmpty(spec_doc_tb.Text) && !string.IsNullOrWhiteSpace(spec_doc_tb.Text) &&
                !string.IsNullOrEmpty(phone_doc_tb.Text) && !string.IsNullOrWhiteSpace(phone_doc_tb.Text))

                Database.change_doc(id_doc_tb.Text, name_doc_tb.Text, spec_doc_tb.Text, phone_doc_tb.Text);

            else if (!string.IsNullOrEmpty(id_doc_tb.Text) && !string.IsNullOrWhiteSpace(id_doc_tb.Text))
            {
                label_doc.Visible = true;
                label_doc.Text = "Заполните все поля для изменения";

            }

            load_data_doc();
        }

        private void Delete_doc_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label_doc.Visible)
                label_doc.Visible = false;

            if (!string.IsNullOrEmpty(id_doc_tb.Text) && !string.IsNullOrWhiteSpace(id_doc_tb.Text))
                Database.delete_client(id_doc_tb.Text,"doctor");
            else
            {
                label_doc.Visible = true;
                label_doc.Text = "Заполните поле id_doc для удаления";
            }
            load_data_doc();
        }

        private void Add_item_bt_Click(object sender, EventArgs e)
        {
            if (label_item.Visible)
                label_item.Visible = false;

            if (!string.IsNullOrEmpty(name_item_tb.Text) && !string.IsNullOrWhiteSpace(name_item_tb.Text) &&
                !string.IsNullOrEmpty(amount_item_tb.Text) && !string.IsNullOrWhiteSpace(amount_item_tb.Text))

                Database.add_item(name_item_tb.Text, Convert.ToInt32(amount_item_tb.Text));

            else
            {
                label_item.Visible = true;

                label_item.Text = "Поля данных не заполнены!";
            }

            load_data_item();
        }

        private void Change_item_bt_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label_item.Visible)
                label_item.Visible = false;

            if (!string.IsNullOrEmpty(id_item_tb.Text) && !string.IsNullOrWhiteSpace(id_item_tb.Text) &&
                !string.IsNullOrEmpty(name_item_tb.Text) && !string.IsNullOrWhiteSpace(name_item_tb.Text) &&
                !string.IsNullOrEmpty(amount_item_tb.Text) && !string.IsNullOrWhiteSpace(amount_item_tb.Text))

                Database.change_item(id_item_tb.Text, name_item_tb.Text, Convert.ToInt32(amount_item_tb.Text));

            else if (!string.IsNullOrEmpty(id_item_tb.Text) && !string.IsNullOrWhiteSpace(id_item_tb.Text))
            {
                label_item.Visible = true;
                label_item.Text = "Заполните все поля для изменения";

            }

            load_data_item();
        }

        private void Delete_item_bt_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label_item.Visible)
                label_item.Visible = false;

            if (!string.IsNullOrEmpty(id_item_tb.Text) && !string.IsNullOrWhiteSpace(id_item_tb.Text))
                Database.delete_client(id_item_tb.Text, "item");
            else
            {
                label_item.Visible = true;
                label_item.Text = "Заполните поле id_item для удаления";
            }
            load_data_item();
        }

        private void Add_order_bt_Click(object sender, EventArgs e)
        {
            if (label_order.Visible)
                label_order.Visible = false;

            if 
                (datepick_order.Value != null)

                Database.add_order(datepick_order.Value.Date);

            else
            {
                label_order.Visible = true;

                label_order.Text = "Поля данных не заполнены!";
            }

            load_data_order();
        }

        private void Change_order_bt_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label_order.Visible)
                label_order.Visible = false;

            if (!string.IsNullOrEmpty(id_order_tb.Text) && !string.IsNullOrWhiteSpace(id_order_tb.Text) &&
                datepick.Value != null)

                Database.change_order(id_order_tb.Text,datepick.Value);

            else if (!string.IsNullOrEmpty(id_order_tb.Text) && !string.IsNullOrWhiteSpace(id_order_tb.Text))
            {
                label_order.Visible = true;
                label_order.Text = "Заполните все поля для изменения";

            }

            load_data_order();
        }

        private void Delete_order_bt_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label_order.Visible)
                label_order.Visible = false;

            if (!string.IsNullOrEmpty(id_order_tb.Text) && !string.IsNullOrWhiteSpace(id_order_tb.Text))
                Database.delete_client(id_order_tb.Text, "order");
            else
            {
                label_order.Visible = true;
                label_order.Text = "Заполните поле id_order для удаления";
            }
            load_data_order();
        }

        private void Add_request_bt_Click(object sender, EventArgs e)
        {
            if (label_request.Visible)
                label_request.Visible = false;

            if (!string.IsNullOrEmpty(request_tb.Text) && !string.IsNullOrWhiteSpace(request_tb.Text))

                Database.add_request(request_tb.Text);

            else
            {
                label_request.Visible = true;

                label_request.Text = "Поля данных не заполнены!";
            }

            load_data_request();
        }

        private void Change_request_bt_Click(object sender, EventArgs e)
        {

            this.OpenConnection();
            if (label_request.Visible)
                label_request.Visible = false;

            if (!string.IsNullOrEmpty(id_request_tb.Text) && !string.IsNullOrWhiteSpace(id_request_tb.Text) &&
                !string.IsNullOrEmpty(request_tb.Text) && !string.IsNullOrWhiteSpace(request_tb.Text))

                Database.change_request(id_request_tb.Text, request_tb.Text);

            else if (!string.IsNullOrEmpty(id_request_tb.Text) && !string.IsNullOrWhiteSpace(id_request_tb.Text))
            {
                label_request.Visible = true;
                label_request.Text = "Заполните все поля для изменения";

            }

            load_data_request();
        }

        private void Delete_request_bt_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label_request.Visible)
                label_request.Visible = false;

            if (!string.IsNullOrEmpty(id_request_tb.Text) && !string.IsNullOrWhiteSpace(id_request_tb.Text))
                Database.delete_client(id_request_tb.Text, "request");
            else
            {
                label_request.Visible = true;
                label_request.Text = "Заполните поле id_request для удаления";
            }
            load_data_request();
        }

        private void Add_service_bt_Click(object sender, EventArgs e)
        {
            if (label_service.Visible)
                label_service.Visible = false;

            if (!string.IsNullOrEmpty(name_service_tb.Text) && !string.IsNullOrWhiteSpace(name_service_tb.Text) &&
                !string.IsNullOrEmpty(price_service_tb.Text) && !string.IsNullOrWhiteSpace(price_service_tb.Text))

                Database.add_service(name_service_tb.Text, Convert.ToInt32(price_service_tb.Text));

            else
            {
                label_service.Visible = true;

                label_service.Text = "Поля данных не заполнены!";
            }

            load_data_service();
        }

        private void Change_service_bt_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label_service.Visible)
                label_service.Visible = false;

            if (!string.IsNullOrEmpty(id_service_tb.Text) && !string.IsNullOrWhiteSpace(id_service_tb.Text) &&
                !string.IsNullOrEmpty(name_service_tb.Text) && !string.IsNullOrWhiteSpace(name_service_tb.Text) &&
                !string.IsNullOrEmpty(price_service_tb.Text) && !string.IsNullOrWhiteSpace(price_service_tb.Text))

                Database.change_service(id_service_tb.Text, name_service_tb.Text, Convert.ToInt32(price_service_tb.Text));

            else if (!string.IsNullOrEmpty(id_service_tb.Text) && !string.IsNullOrWhiteSpace(id_service_tb.Text))
            {
                label_service.Visible = true;
                label_service.Text = "Заполните все поля для изменения";

            }

            load_data_service();
        }

        private void Delete_service_bt_Click(object sender, EventArgs e)
        {
            this.OpenConnection();
            if (label_service.Visible)
                label_service.Visible = false;

            if (!string.IsNullOrEmpty(id_service_tb.Text) && !string.IsNullOrWhiteSpace(id_service_tb.Text))
                Database.delete_client(id_service_tb.Text, "service");
            else
            {
                label_service.Visible = true;
                label_service.Text = "Заполните поле id_service для удаления";
            }
            load_data_service();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                id_box.Text = row.Cells[0].Value.ToString();
                name_box.Text = row.Cells[1].Value.ToString();
                datepick.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                polis_box.Text = row.Cells[3].Value.ToString();
            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                id_doc_tb.Text = row.Cells[0].Value.ToString();
                name_doc_tb.Text = row.Cells[1].Value.ToString();
                spec_doc_tb.Text = row.Cells[2].Value.ToString();
                phone_doc_tb.Text = row.Cells[3].Value.ToString();
            }
        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];
                id_item_tb.Text = row.Cells[0].Value.ToString();
                name_item_tb.Text = row.Cells[1].Value.ToString();
                amount_item_tb.Text = row.Cells[2].Value.ToString();
            }
        }

        private void DataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView4.Rows[e.RowIndex];
                id_order_tb.Text = row.Cells[0].Value.ToString();
                datepick.Value = Convert.ToDateTime(row.Cells[1].Value.ToString());
            }

        }

        private void DataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView5.Rows[e.RowIndex];
                    id_request_tb.Text = row.Cells[0].Value.ToString();
                    request_tb.Text = row.Cells[1].Value.ToString();
                }
            }
        

        private void DataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView6.Rows[e.RowIndex];
                    id_service_tb.Text = row.Cells[0].Value.ToString();
                    name_service_tb.Text = row.Cells[1].Value.ToString();
                    price_service_tb.Text = row.Cells[2].Value.ToString();
                }
            }
        }
    }
    


