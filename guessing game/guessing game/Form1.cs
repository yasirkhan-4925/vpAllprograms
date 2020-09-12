using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessing_game
{
    public partial class Form1 : Form
    {
        Form2 a = new Form2();
        Form3 b = new Form3();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked && this.textBox1.Text == "sameer" && this.textBox2.Text == "sameer")
            {
                a.n1 = textBox1.Text;
                a.Show();
            }
            else {

               

                this.Show();
            }
          
            if(radioButton2.Checked&&textBox1.Text=="sameer" &&textBox2.Text=="sameer")
            {
                b.b1 = textBox1.Text;
                b.Show();

            }
            else
            {
                this.Show();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
