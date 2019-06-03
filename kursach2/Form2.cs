using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Enterbt_Click(object sender, EventArgs e)
        {
            string mail = logintb.Text;
            string password = passtb.Text;
            MySqlConnection myconn;
            myconn = new MySqlConnection("server=silan.zyns.com" + "; database=cyvarev; UID=cyvarev" + "; PWD=cyvarev" + ";");
            myconn.Open();

            string sql = "select password from user where mail = '" + mail + "'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, myconn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][0].ToString().Equals(password))
                {
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                    this.Close();
                }

                else MessageBox.Show("Неверный пароль");
            }
            else
            {
                MessageBox.Show("Данный логин не найден");
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
