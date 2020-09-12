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
    public partial class Form3 : Form

    {
        int n, count = 0;
        public string b1;
        Random random = new Random();
        int num;
        string numSt;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = random.Next(0, 23);
            num += n;
            numSt = n.ToString();



            count++;
            this.button1.Enabled = false;
            this.button1.Text = numSt;
            if (count >1)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;

                this.button5.Enabled = false;
                this.button6.Enabled = false;


                if (num > 50)
                {
                    MessageBox.Show("congratz" + " " + b1 + " " + "you win");
                }
                else
                {
                    MessageBox.Show("you lose " + " " + b1);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = random.Next(9, 28);
            num += n;

            numSt = n.ToString();


            count++;
            this.button2.Enabled = false;
            this.button2.Text = numSt;
            if (count > 1)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;

                this.button5.Enabled = false;
                this.button6.Enabled = false;


                if (num > 50)
                {
                    MessageBox.Show("congratz" + " " + b1 + " " + "you win");
                }
                else
                {
                    MessageBox.Show("you lose " + " " + b1);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = random.Next(9, 27);
            num += n;

            numSt = n.ToString();


            count++;
            this.button3.Enabled = false;
            this.button3.Text = numSt;
            if (count > 1)
            {
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button4.Enabled = false;

                this.button5.Enabled = false;
                this.button6.Enabled = false;


                if (num > 50)
                {
                    MessageBox.Show("congratz" + " " + b1 + " " + "you win");
                }
                else
                {
                    MessageBox.Show("you lose " + " " + b1);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n = random.Next(9, 27);
            num += n;

            numSt = n.ToString();


            count++;
            this.button4.Enabled = false;
            this.button4.Text = numSt;
            if (count > 1)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button2.Enabled = false;

                this.button5.Enabled = false;
                this.button6.Enabled = false;


                if (num > 50)
                {
                    MessageBox.Show("congratz" + " " + b1 + " " + "you win");
                }
                else
                {
                    MessageBox.Show("you lose " + " " + b1);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            n = random.Next(10, 28);
            num += n;

            numSt = n.ToString();


            count++;
            this.button5.Enabled = false;
            this.button5.Text = numSt;
            if (count > 1)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;

                this.button2.Enabled = false;
                this.button6.Enabled = false;


                if (num > 50)
                {
                    MessageBox.Show("congratz" + " " + b1 + " " + "you win");
                }
                else
                {
                    MessageBox.Show("you lose " + " " + b1);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            n = random.Next(10, 25);
            num += n;

            numSt = n.ToString();


            count++;
            this.button6.Enabled = false;
            this.button6.Text = numSt;
            if (count > 1)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;

                this.button5.Enabled = false;
                this.button2.Enabled = false;



                if (num > 50)
                {
                    MessageBox.Show("congratz" + " " + b1 + " " + "you win");
                }
                else
                {
                    MessageBox.Show("you lose " + " " + b1);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            count = 0;
            num = 0;
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;

            this.button5.Enabled = true;
            this.button6.Enabled = true;
         
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";

            button5.Text = "";
            button6.Text = "";
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num = 0;
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
