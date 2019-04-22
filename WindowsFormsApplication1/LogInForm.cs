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

namespace WindowsFormsApplication1
{

  

    public partial class LogInForm : Form
    {
       

        public LogInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; persistsecurityinfo = True; database = inventario_ic");
            conn.Open();


            MySqlCommand code = new MySqlCommand();
            MySqlConnection conect = new MySqlConnection();
            code.Connection = conn;

            code.CommandText = ("Select * from user Where WWID = '" + textBox1 + "' and password = '" + textBox2 + "' ");

            MySqlDataReader rdr = code.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("Welcome");
            }
            else
            {
                MessageBox.Show("Incorrect WWID or password");
            }

            conn.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
