using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sendSms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" && textBox2.Text=="")
            {
                MessageBox.Show("Please enter username and password");
            }
            else if(textBox1.Text=="")
            {
                MessageBox.Show("Please enter username");
            }
            else if(textBox2.Text=="")
            {
                MessageBox.Show("Please enter Password");
            }
            else if(textBox1.Text=="yasirkhan4922" && textBox2.Text=="1234")
            {
                Form2 obj = new Form2();
                obj.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("wrong username or pass");
            }
        }
    }
}
