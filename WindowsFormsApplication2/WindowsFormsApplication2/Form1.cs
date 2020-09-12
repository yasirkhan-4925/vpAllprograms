using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        double num1, num2, total;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (op == "+")
            { }
            num2 = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            total = num1 + num2;
            textBox1.Text = total + "";

        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // textBox1.Text = textBox1.Text + "4";
           textbox
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(TextBox1.Text);
            textBox1.Text = "";
            op = "+";
        }
    }
}
