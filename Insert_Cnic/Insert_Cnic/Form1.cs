using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insert_Cnic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text=="")
            {
                MessageBox.Show("Please Enter Name");
            }
            else if(textBox2.Text=="")
            {
                MessageBox.Show("Please Enter Father Name");
            }
            else if(comboBox1.Text=="")
            {
                MessageBox.Show("Please select gender");
            }
            else if(textBox4.Text=="")
            {
                MessageBox.Show("Please enter CNIC");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Please enter country ");
            }
            else if(textBox5.Text=="")
            {
                MessageBox.Show("Please enter DOB");

            }
            else if(textBox6.Text=="")
            {
                MessageBox.Show("Please enter date of issue");
            }
            else
            {
                int row = dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[row].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[row].Cells[2].Value = comboBox1.Text;
                dataGridView1.Rows[row].Cells[3].Value = textBox3.Text;
                dataGridView1.Rows[row].Cells[4].Value = textBox4.Text;
                dataGridView1.Rows[row].Cells[5].Value = textBox5.Text;
                dataGridView1.Rows[row].Cells[6].Value = textBox6.Text;
                textBox1.Text = "";
                comboBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox1.Text = "";
                textBox1.Text = "";
            }
          


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
