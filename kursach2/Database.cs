using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach2
{
    class Database
    {
        public static string server = "127.0.0.1";
        public static string database = "usbw";
        public static string uid = "root";
        public static string password = "Gagarin156";
        public static string connectionString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + uid + ";PASSWORD=" + password + ";PORT=3307";
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


            MySqlCommand command = new MySqlCommand("UPDATE doctor SET name=@name, spec=@spec, phone=@phone WHERE id_doctor=@id_doctor", connection);

            command.Parameters.AddWithValue("id_doctor", id);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("spec", spec);
            command.Parameters.AddWithValue("phone", phone);

            command.ExecuteNonQuery();
            CloseConnection();

        }

        public static void add_branch(string name, string phone)
        {
            OpenConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO branch (name, phone) VALUES (@name, @phone)", connection);

            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("phone", phone);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public static void change_branch(string id, string name, string phone )
        {
            OpenConnection();


            MySqlCommand command = new MySqlCommand("UPDATE branch SET name=@name, phone=@phone WHERE id_branch=@id_branch", connection);

            command.Parameters.AddWithValue("id_branch", id);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("phone", phone);

            command.ExecuteNonQuery();
            CloseConnection();

        }

        public static void add_order(DateTime givedate, string service, string client, string branch)
        {

            OpenConnection();


            string sql = "select id_service, id_client, id_branch " +
                "from service, client, branch" +
                " where client.name = '" + client + "'" +
                "and service.name='" + service + "'" +
                "and branch.name='" + branch + "'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            MySqlCommand command = new MySqlCommand("INSERT INTO ord (id_service, givedate, id_client,  id_branch ) VALUES (@id_service, @givedate, @id_client, @id_branch)", connection);

            command.Parameters.AddWithValue("givedate", givedate);
            command.Parameters.AddWithValue("id_service", dt.Rows[0][0]);
            command.Parameters.AddWithValue("id_client", dt.Rows[0][1]);
            command.Parameters.AddWithValue("id_branch", dt.Rows[0][2]);

            command.ExecuteNonQuery();

            CloseConnection();
            
        }

        public static void change_order(string id, DateTime givedate, string service, string client, string branch)
        {
            OpenConnection();

            string sql = "select id_service, id_client, id_branch " +
                "from service, client, branch" +
                " where client.name = '" + client + "'" +
                "and service.name='"+service+"'" +
                "and branch.name='"+branch+"'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            MySqlCommand command = new MySqlCommand("UPDATE ord SET id_service=@id_service, givedate=@givedate, id_client=@id_client, id_branch=@id_branch  WHERE id_ord=@id_ord", connection);


            command.Parameters.AddWithValue("id_ord", id);
            command.Parameters.AddWithValue("givedate", givedate);
            command.Parameters.AddWithValue("id_service", dt.Rows[0][0]);
            command.Parameters.AddWithValue("id_client", dt.Rows[0][1]);
            command.Parameters.AddWithValue("id_branch", dt.Rows[0][2]);

            command.ExecuteNonQuery();

            CloseConnection();
            

        }

        public static void add_service(string name, int price)
        {
            OpenConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO service (name, price) VALUES (@name, @price)", connection);

            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("price", price);
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public static void change_service(string id, string name, int price)
        {
            OpenConnection();


            MySqlCommand command = new MySqlCommand("UPDATE service SET name=@name, price=@price WHERE id_service=@id_service", connection);

            command.Parameters.AddWithValue("id_service", id);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("price", price);

            command.ExecuteNonQuery();
            CloseConnection();

        }
    }
}
