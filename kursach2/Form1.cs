using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace kursach2
{
    public partial class Form1 : MetroForm
    {
        private string server = "127.0.0.1";
        private string database = "usbw";
        private string uid = "root";
        private string password = "Gagarin156";
        private MySqlConnection connection;
        private MySqlDataAdapter mySqlDataAdapter;


        public Form1()
        {
            InitializeComponent();
            load_data(metroGrid1, "client");
            load_data(metroGrid2, "doctor");
            load_data(metroGrid3, "ord");
            load_data(metroGrid4, "service");
            load_data(metroGrid5, "branch");

            load_data_cb(ord_service_cb, "service");
            load_data_cb(ord_client_cb, "client");
            load_data_cb(ord_branch_cb, "branch");

        }

        private void load_data(DataGridView metroGrid, string table)
        {
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";PORT=3307";

            connection = new MySqlConnection(connectionString);


            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("select * from " + table, connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                metroGrid.DataSource = DS.Tables[0];
                this.CloseConnection();
            }

        }

        private void load_data_cb(ComboBox cb, string table)
        {
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";PORT=3307";

            using (connection = new MySqlConnection(connectionString)) ;

            {
                connection.Open();
                var query = "SELECT name FROM " + table;
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cb.Items.Add(reader.GetString("name"));
                        }
                    }
                }
                connection.Close();
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

        private void Add_client_bt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name_client_tb.Text) && !string.IsNullOrWhiteSpace(name_client_tb.Text) &&
                datepick.Value != null &&
                !string.IsNullOrEmpty(polis_client_tb.Text) && !string.IsNullOrWhiteSpace(polis_client_tb.Text))

                Database.add_client(name_client_tb.Text, datepick.Value, polis_client_tb.Text);
            else
            {

                MessageBox.Show("Поля данных не заполнены!");
            }

            load_data(metroGrid1, "client");
            ord_client_cb.Items.Clear();
            load_data_cb(ord_client_cb, "client");
        }

        private void Change_client_bt_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(id_client_tb.Text) && !string.IsNullOrWhiteSpace(id_client_tb.Text) &&
                !string.IsNullOrEmpty(name_client_tb.Text) && !string.IsNullOrWhiteSpace(name_client_tb.Text) &&
                datepick.Value != null &&
                !string.IsNullOrEmpty(polis_client_tb.Text) && !string.IsNullOrWhiteSpace(polis_client_tb.Text))
                Database.change_client(id_client_tb.Text, name_client_tb.Text, datepick.Value, polis_client_tb.Text);
            else if (!string.IsNullOrEmpty(id_client_tb.Text) && !string.IsNullOrWhiteSpace(id_client_tb.Text))
            {
                MessageBox.Show("Поля данных не заполнены!");

            }

            load_data(metroGrid1, "client");
        }

        private void Delete_client_bt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id_client_tb.Text) && !string.IsNullOrWhiteSpace(id_client_tb.Text))
                Database.delete_client(id_client_tb.Text, "client");
            else
            {
                MessageBox.Show("Заполните поле id_client для удаления");
            }

            load_data(metroGrid1, "client");
        }

        private void Add_doctor_bt_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(name_doc_tb.Text) && !string.IsNullOrWhiteSpace(name_doc_tb.Text) &&
                !string.IsNullOrEmpty(spec_doc_tb.Text) && !string.IsNullOrWhiteSpace(spec_doc_tb.Text) &&
                !string.IsNullOrEmpty(phone_doc_tb.Text) && !string.IsNullOrWhiteSpace(phone_doc_tb.Text))
                Database.add_doc(name_doc_tb.Text, spec_doc_tb.Text, phone_doc_tb.Text);

            else
            {
                MessageBox.Show("Поля данных не заполнены!");
            }

            load_data(metroGrid2, "doctor");

        }

        private void Change_doctor_bt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id_doc_tb.Text) && !string.IsNullOrWhiteSpace(id_doc_tb.Text) &&
                !string.IsNullOrEmpty(name_doc_tb.Text) && !string.IsNullOrWhiteSpace(name_doc_tb.Text) &&
                !string.IsNullOrEmpty(spec_doc_tb.Text) && !string.IsNullOrWhiteSpace(spec_doc_tb.Text) &&
                !string.IsNullOrEmpty(phone_doc_tb.Text) && !string.IsNullOrWhiteSpace(phone_doc_tb.Text))
                Database.change_doc(id_doc_tb.Text, name_doc_tb.Text, spec_doc_tb.Text, phone_doc_tb.Text);

            else if (!string.IsNullOrEmpty(id_doc_tb.Text) && !string.IsNullOrWhiteSpace(id_doc_tb.Text))
            {
                MessageBox.Show("Заполните все поля для изменения");

            }

            load_data(metroGrid2, "doctor");
        }

        private void Delete_doctor_bt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id_doc_tb.Text) && !string.IsNullOrWhiteSpace(id_doc_tb.Text))
                Database.delete_client(id_doc_tb.Text, "doctor");
            else
            {
                MessageBox.Show("Заполните поле id_doc для удаления");
            }
            load_data(metroGrid2, "doctor");
        }

        private void Add_branch_bt_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name_branch_tb.Text) && !string.IsNullOrWhiteSpace(name_branch_tb.Text) &&
                !string.IsNullOrEmpty(phone_branch_tb.Text) && !string.IsNullOrWhiteSpace(phone_branch_tb.Text))
                Database.add_branch(name_branch_tb.Text, phone_branch_tb.Text);

            else
            {
                MessageBox.Show("Поля данных не заполнены!");
            }

            load_data(metroGrid5, "branch");
            ord_branch_cb.Items.Clear();
            load_data_cb(ord_branch_cb, "branch");
        }

        private void Change_branch_bt_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id_branch_tb.Text) && !string.IsNullOrWhiteSpace(id_branch_tb.Text) &&
                !string.IsNullOrEmpty(name_branch_tb.Text) && !string.IsNullOrWhiteSpace(name_branch_tb.Text) &&
                !string.IsNullOrEmpty(phone_branch_tb.Text) && !string.IsNullOrWhiteSpace(phone_branch_tb.Text))

                Database.change_branch(id_branch_tb.Text, name_branch_tb.Text, phone_branch_tb.Text);

            else if (!string.IsNullOrEmpty(id_branch_tb.Text) && !string.IsNullOrWhiteSpace(id_branch_tb.Text))
            {
                MessageBox.Show("Заполните все поля для изменения");

            }

            load_data(metroGrid5, "branch");
            ord_branch_cb.Items.Clear();
            load_data_cb(ord_branch_cb, "branch");
        }

        private void Delete_branch_bt_Click_1(object sender, EventArgs e)
        {
        


            if (!string.IsNullOrEmpty(id_branch_tb.Text) && !string.IsNullOrWhiteSpace(id_branch_tb.Text))
                Database.delete_client(id_branch_tb.Text, "branch");
            else
            {
                MessageBox.Show("Заполните поле id_item для удаления");
            }
            load_data(metroGrid5, "branch");
            ord_branch_cb.Items.Clear();
            load_data_cb(ord_branch_cb, "branch");
        }

        private void Add_order_bt_Click(object sender, EventArgs e)
        {
    

            if
                (datepick_order.Value != null)

                Database.add_order(datepick_order.Value.Date, ord_service_cb.Text, ord_client_cb.Text, ord_branch_cb.Text);

            else
            {
                MessageBox.Show("Поля данных не заполнены!");
            }

            load_data(metroGrid3, "order");
        }

        private void Change_order_bt_Click(object sender, EventArgs e)
        {
           


            if (!string.IsNullOrEmpty(id_order_tb.Text) && !string.IsNullOrWhiteSpace(id_order_tb.Text) &&
                datepick.Value != null)

                Database.change_order(id_order_tb.Text, datepick.Value, ord_service_cb.Text, ord_client_cb.Text, ord_branch_cb.Text);

            else if (!string.IsNullOrEmpty(id_order_tb.Text) && !string.IsNullOrWhiteSpace(id_order_tb.Text))
            {
                MessageBox.Show("Заполните все поля для изменения");

            }

            load_data(metroGrid3, "order");
        }

        private void Delete_order_bt_Click_1(object sender, EventArgs e)
        { 
            if (!string.IsNullOrEmpty(id_order_tb.Text) && !string.IsNullOrWhiteSpace(id_order_tb.Text))
                Database.delete_client(id_order_tb.Text, "ord");
            else
            {
                MessageBox.Show("Заполните поле id_order для удаления");
            }
            load_data(metroGrid3, "order");
        }



        private void Add_service_bt_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name_service_tb.Text) && !string.IsNullOrWhiteSpace(name_service_tb.Text) &&
                !string.IsNullOrEmpty(price_service_tb.Text) && !string.IsNullOrWhiteSpace(price_service_tb.Text))
                Database.add_service(name_service_tb.Text, Convert.ToInt32(price_service_tb.Text));
            else
            {
                MessageBox.Show("Поля данных не заполнены!");
            }

            load_data(metroGrid4, "service");
            ord_service_cb.Items.Clear();
            load_data_cb(ord_service_cb, "service");
        }

        private void Change_service_bt_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id_service_tb.Text) && !string.IsNullOrWhiteSpace(id_service_tb.Text) &&
                !string.IsNullOrEmpty(name_service_tb.Text) && !string.IsNullOrWhiteSpace(name_service_tb.Text) &&
                !string.IsNullOrEmpty(price_service_tb.Text) && !string.IsNullOrWhiteSpace(price_service_tb.Text))
                Database.change_service(id_service_tb.Text, name_service_tb.Text, Convert.ToInt32(price_service_tb.Text));

            else if (!string.IsNullOrEmpty(id_service_tb.Text) && !string.IsNullOrWhiteSpace(id_service_tb.Text))
            {
                MessageBox.Show("Заполните все поля для изменения");
            }

            load_data(metroGrid4, "service");
            ord_service_cb.Items.Clear();
            load_data_cb(ord_service_cb, "service");
        }

        private void Delete_service_bt_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(id_service_tb.Text) && !string.IsNullOrWhiteSpace(id_service_tb.Text))
                Database.delete_client(id_service_tb.Text, "service");
            else
            {
                MessageBox.Show("Заполните поле id_service для удаления");
            }
            load_data(metroGrid4, "service");
            ord_service_cb.Items.Clear();
            load_data_cb(ord_service_cb, "service");
        }

        private void MetroGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                id_client_tb.Text = row.Cells[0].Value.ToString();
                name_client_tb.Text = row.Cells[1].Value.ToString();
                datepick.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                polis_client_tb.Text = row.Cells[3].Value.ToString();
            }
        }

        private void MetroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid2.Rows[e.RowIndex];
                id_doc_tb.Text = row.Cells[0].Value.ToString();
                name_doc_tb.Text = row.Cells[1].Value.ToString();
                spec_doc_tb.Text = row.Cells[2].Value.ToString();
                phone_doc_tb.Text = row.Cells[3].Value.ToString();

            }
        }

        private void MetroGrid5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid5.Rows[e.RowIndex];
                id_branch_tb.Text = row.Cells[0].Value.ToString();
                name_branch_tb.Text = row.Cells[1].Value.ToString();
                phone_branch_tb.Text = row.Cells[2].Value.ToString();
            }
        }


        private void MetroGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid3.Rows[e.RowIndex];
                id_order_tb.Text = row.Cells[0].Value.ToString();
                ord_service_cb.Text = row.Cells[1].Value.ToString();
                datepick_order.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                ord_client_cb.Text = row.Cells[3].Value.ToString();
                ord_branch_cb.Text = row.Cells[4].Value.ToString();
            }
        }



        private void MetroGrid4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid4.Rows[e.RowIndex];
                id_service_tb.Text = row.Cells[0].Value.ToString();
                name_service_tb.Text = row.Cells[1].Value.ToString();
                price_service_tb.Text = row.Cells[2].Value.ToString();
            }
        }



















        //private void Zapros_bt_Click(object sender, EventArgs e)
        //{
        //    string q = "";
        //    bool c = true;
        //    switch (numpick.Value)
        //    {
        //        case 1:
        //            q = "SELECT client.name, ord.id_ord, branch.name " +
        //                "FROM client, ord, branch " +
        //                "WHERE ord.id_branch = branch.id_branch AND ord.id_client = client.id_client";
        //            break;
        //        case 2:
        //            q = "SELECT DISTINCT client.name FROM client, ord " +
        //                "WHERE client.id_client = ord.id_client";
        //            break;
        //        case 3:
        //            q = "SELECT id_branch, name FROM branch " +
        //                "WHERE LENGTH(phone)<8";
        //            break;
        //        case 4:
        //            q = "SELECT * FROM service " +
        //                "WHERE price IN (SELECT MAX(price) FROM service)";
        //            break;
        //        case 5:
        //            q = "SELECT name FROM service " +
        //                 "WHERE price >500";
        //            break;
        //        case 6:
        //            q = "SELECT name FROM client " +
        //                 "WHERE LENGTH(polis)<6";
        //            break;
        //        case 7:
        //            q = "SELECT name FROM doctor " +
        //                 "WHERE spec = 'Hirurg'";
        //            break;
        //        case 8:
        //            q = "SELECT client.id_client, client.name, COUNT(ord.id_ord) FROM ord, client  " +
        //                 "WHERE ord.id_Client=Client.id_client GROUP BY Client.id_client";
        //            break;
        //        case 9:
        //            q = "SELECT name, YEAR(CURRENT_DATE) - YEAR(birth) AS age FROM Client " +
        //                "WHERE (CURRENT_DATE - birth)>60";
        //            break;
        //        default:
        //            c = false;
        //            break;
        //    }
        //    if (c = true)
        //        load_data_zapros(q);
        //    else MessageBox.Show("Необходимо выбрать запрос от 1 до 9");
        //}

        //private void Numpick_ValueChanged(object sender, EventArgs e)
        //{
        //    string q = "";
        //    switch (numpick.Value)
        //    {
        //        case 1:
        //            q = "Отчет по клиентам, их заказам и отделениям, в которые они поступили";
        //            break;
        //        case 2:
        //            q = "Отчет по клиентам, которые делали хотя бы один заказ";

        //            break;
        //        case 3:
        //            q = "Показывает названия отделений, у которых номера телефонов короче 8 символов ";

        //            break;
        //        case 4:
        //            q = "Показывает данные об услугах с наибольшей ценой ";
        //            break;
        //        case 5:
        //            q = "Показывает названия услуг с ценой больше 500";
        //            break;
        //        case 6:
        //            q = "Показывает имена клиентов с длиной полиса более 6 символов";
        //            break;
        //        case 7:
        //            q = "Показывает всех хирургов";
        //            break;
        //        case 8:
        //            q = "Отчет по клиентам и числу их заказов ";
        //            break;
        //        case 9:
        //            q = "Показывает клиентов старше 60 лет";
        //            break;
        //        default:
        //            label_zapros.Hide();
        //            break;
        //    }
        //    label_zapros.Text = q;
        //}




    }
}