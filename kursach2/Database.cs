using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach2
{
    class Database
    {
        public static string server = "silan.zyns.com";
        public static string database = "cyvarev";
        public static string uid = "cyvarev";
        public static string password = "cyvarev";
        public static string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        public static MySqlConnection connection = new MySqlConnection(connectionString);
        public static bool OpenConnection()
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

        public static bool CloseConnection()
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

        public static void change_client(string id, string name, DateTime date, string polis)
        {
            OpenConnection();


            MySqlCommand command = new MySqlCommand("UPDATE Client SET name=@name, birth=@birth, polis=@polis WHERE id_client=@id_client", connection);

            command.Parameters.AddWithValue("id_client", id);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("birth", date);
            command.Parameters.AddWithValue("polis", polis);

            command.ExecuteNonQuery();
            CloseConnection();

        }


        public static void add_client(string name, DateTime birth, string polis)
        {
            OpenConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO Client (name, birth, polis) VALUES (@name, @birth, @polis)", connection);

            command.Parameters.AddWithValue("name", name);

            command.Parameters.AddWithValue("birth", birth);

            command.Parameters.AddWithValue("polis", polis);

            command.ExecuteNonQuery();
            CloseConnection();
        }



        public static void delete_client(string id, string table)
        {
            OpenConnection();

            MySqlCommand command = new MySqlCommand("DELETE FROM "+table+" WHERE id_"+table+ " =@id_"+table, connection);

            command.Parameters.AddWithValue("id_"+table, id);

            command.ExecuteNonQuery();
            CloseConnection();

        }

        public static void add_doc(string name, string spec, string phone)
        {
            OpenConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO doctor (name, spec, phone) VALUES (@name, @spec, @phone)", connection);

            command.Parameters.AddWithValue("name", name);

            command.Parameters.AddWithValue("spec", spec);

            command.Parameters.AddWithValue("phone", phone);

            command.ExecuteNonQuery();
            CloseConnection();
        }

        public static void change_doc(string id, string name, string spec, string phone)
        {
            OpenConnection();


            MySqlCommand command = new MySqlCommand("UPDATE Client SET name=@name, spec=@spec, phone=@phone WHERE id_doctor=@id_doc", connection);

            command.Parameters.AddWithValue("id_doctor", id);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("spec", spec);
            command.Parameters.AddWithValue("phone", phone);

            command.ExecuteNonQuery();
            CloseConnection();

        }

        public static void add_item(string name, int amount)
        {
            OpenConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO item (item_name, item_amount) VALUES (@item_name, @item_amount)", connection);

            command.Parameters.AddWithValue("item_name", name);

            command.Parameters.AddWithValue("item_amount", amount);
            
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public static void change_item(string id, string name, int amount )
        {
            OpenConnection();


            MySqlCommand command = new MySqlCommand("UPDATE item SET item_name=@item_name, item_amount=@item_amount WHERE id_item=@id_item", connection);

            command.Parameters.AddWithValue("id_item", id);
            command.Parameters.AddWithValue("item_name", name);
            command.Parameters.AddWithValue("item_amount", amount);

            command.ExecuteNonQuery();
            CloseConnection();

        }

        public static void add_order(DateTime ord_date)
        {
            OpenConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO Ord (ord_date) VALUES (@ord_date)", connection);

            command.Parameters.AddWithValue("ord_date", ord_date);

            command.ExecuteNonQuery();
            CloseConnection();
        }

        public static void change_order(string id, DateTime ord_date)
        {
            OpenConnection();


            MySqlCommand command = new MySqlCommand("UPDATE Ord SET ord_date=@ord_date WHERE id_order=@id_order", connection);

            command.Parameters.AddWithValue("id_order", id);
            command.Parameters.AddWithValue("ord_date", ord_date);

            command.ExecuteNonQuery();
            CloseConnection();

        }

        public static void add_request(string text)
        {
            OpenConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO request (request_text) VALUES (@request_text)", connection);

            command.Parameters.AddWithValue("request_text", text);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public static void change_request(string id, string text)
        {
            OpenConnection();


            MySqlCommand command = new MySqlCommand("UPDATE request SET request_text=@request_text WHERE id_request=@id_request", connection);

            command.Parameters.AddWithValue("id_request", id);
            command.Parameters.AddWithValue("request_text", text);

            command.ExecuteNonQuery();
            CloseConnection();

        }

        public static void add_service(string name, int price)
        {
            OpenConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO service (service_name, price) VALUES (@service_name, @price)", connection);

            command.Parameters.AddWithValue("service_name", name);

            command.Parameters.AddWithValue("price", price);

            command.ExecuteNonQuery();
            CloseConnection();
        }

        public static void change_service(string id, string name, int price)
        {
            OpenConnection();


            MySqlCommand command = new MySqlCommand("UPDATE service SET service_name=@service_name, price=@price WHERE id_service=@id_service", connection);

            command.Parameters.AddWithValue("id_service", id);
            command.Parameters.AddWithValue("service_name", name);
            command.Parameters.AddWithValue("price", price);

            command.ExecuteNonQuery();
            CloseConnection();

        }
    }
}
