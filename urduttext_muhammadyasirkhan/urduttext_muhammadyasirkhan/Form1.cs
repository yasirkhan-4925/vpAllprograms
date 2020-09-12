using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urduttext_muhammadyasirkhan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            getchar("H", "ح");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getchar("A", "ا");
        }

        private void getchar(string eng_char,string urdu_char)
        {
            textBox1.Text += eng_char;
            textBox2.Text += urdu_char;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            getchar("B", "ب");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getchar("C", "چ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getchar("D", "ڈ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            getchar("E", "ے");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            getchar("F", "ف");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            getchar("G", "گ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            getchar("I", "ی");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            getchar("J", "ج");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            getchar("K", "ک");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            getchar("L", "ل");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            getchar("M", "م");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            getchar("N", "ن");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            getchar("O", "ں");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            getchar("P", "پ");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            getchar("Q", "ق");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            getchar("R", "ر");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            getchar("S", "س");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            getchar("T", "ت");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            getchar("U", "و");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            getchar("V", "و");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            getchar("W", "و");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            getchar("X", "خ");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            getchar("Y", "ی");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            getchar("Z", "ض");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
