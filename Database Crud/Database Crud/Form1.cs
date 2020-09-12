using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Database_Crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string conString = "server=localhost; user id=root ;password =yasirkhan4925;database=cnic_request";
                string loginQuery = "SELECT * FROM login WHERE Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand cmd = new MySqlCommand(loginQuery, con);
                MySqlDataReader reader;
                int count = 0;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    Console.Write(reader.ToString());
                    while (reader.Read())
                    {
                        count = count + 1;
                    }
                    if (count >= 1)
                    {
                        Form2 a = new Form2();
                        a.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid username & password ");
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to get Value due to " + ex);
                }
            }
            else
            {
                MessageBox.Show("please fill both fields");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

