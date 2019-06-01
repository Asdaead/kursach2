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

   

    public static void delete_client(string id)
        {
            OpenConnection();

            MySqlCommand command = new MySqlCommand("DELETE FROM Client WHERE id_client=@id_client", connection);

                command.Parameters.AddWithValue("id_client", id);

                command.ExecuteNonQuery();
                CloseConnection();

            }
           
        }
    }
