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
        public Form1()
        {
            InitializeComponent();
        }

        private void auth_load()
        {
            DataTable dt = new DataTable();
            MySqlConnectionStringBuilder mysqlCSB;
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "silan.zyns.com";
            mysqlCSB.Port = 3306;
            mysqlCSB.Database = "cyvarev";
            mysqlCSB.UserID = "cyvarev";
            mysqlCSB.Password = "cyvarev";
            string queryString = @"SELECT * FROM Client";
            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = mysqlCSB.ConnectionString;
                MySqlCommand com = new MySqlCommand(queryString, con);
                try
                {
                    con.Open();
                    using (MySqlDataReader dr = com.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Load(dr);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            auth_load();
        }

        private int user_type;

        private bool user_check()
        {
            bool b = false;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if ((textBox1.Text == dataGridView1.Rows[i].Cells[0].Value.ToString()) && (textBox2.Text == dataGridView1.Rows[i].Cells[1].Value.ToString()))
                {
                    b = true;
                    user_type = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value.ToString());
                }
            }
            return b;
        }



    }
}
