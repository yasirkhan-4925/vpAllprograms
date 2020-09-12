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
    public partial class Form2 : Form
    {
        int n, count = 0;
        public string n1;
        Random random = new Random();
        int num;
        string numSt;
       
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = random.Next(5, 27);
            num += n;

            numSt = n.ToString();
            

            count++;
            this.button2.Enabled = false;
            this.button2.Text = numSt;
            if (count == 3)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;

                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;


                if (num > 50)
                {
                    MessageBox.Show("congratz" + " " + n1 + " " + "you win");
                }
                else
                {
                    MessageBox.Show("you lose " + " " + n1);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            n = random.Next(5,27);
            num += n;
            numSt = n.ToString();
            
            count++;
            this.button3.Enabled = false;
            this.button3.Text =  numSt;
            if (count == 3)
            {
                this.button2.Enabled = false;
                this.button1.Enabled = false;
                this.button4.Enabled = false;

                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;


                if (num > 50)
                {
                    MessageBox.Show("congratz" + " " + n1 + " " + "you win");
                }
                else
                {
                    MessageBox.Show("you lose " + " " + n1);
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            count = 0;
            num = 0;
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;

            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;
            this.button9.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";

            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n = random.Next(5,27);
            num += n;

            numSt = n.ToString();

            count++;
            this.button4.Enabled = false;
            this.button4.Text = numSt;
            if (count == 3)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button2.Enabled = false;

                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (num > 50)
                {
                    MessageBox.Show("congratz" + " " + n1 + " " + "you win your score is " + num.ToString());

                }
                else
                {
                    MessageBox.Show("you lose " + " " + n1 + " " + "your score is " + num.ToString());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            n = random.Next(5, 27);
            num += n;

            numSt = n.ToString();

            count++;
            this.button5.Enabled = false;
            this.button5.Text = numSt;
            if (count ==3)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;

                this.button2.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (num > 50)
                {
                    MessageBox.Show("congratz" + " " + n1 + " " + "you win");
                }
                else
                {
                    MessageBox.Show("you lose " + " " + n1);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            n = random.Next(5,27);
            num += n;

            numSt = n.ToString();

            count++;
            this.button6.Enabled = false;
            this.button6.Text = numSt;
            if (count == 3)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;

                this.button5.Enabled = false;
                this.button2.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (num > 50)
                {
                    MessageBox.Show("congratz" + " " + n1 + " " + "you win");
                }
                else
                {
                    MessageBox.Show("you lose " + " " + n1);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            n = random.Next(5,27);
            num += n;

            numSt = n.ToString();

            count++;
            this.button7.Enabled = false;
            this.button7.Text = numSt;
            if (count == 3)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;

                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button2.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
                if (num > 50)
                {
                    MessageBox.Show("congratz" + " " + n1 + " " + "you win");
                }
                else
                {
                    MessageBox.Show("you lose " + " " + n1);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            n = random.Next(5, 27);
            num += n;

            numSt = n.ToString();

            count++;
            this.button8.Enabled = false;
            this.button8.Text = numSt;
            if (count ==3)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;

                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button2.Enabled = false;
                this.button9.Enabled = false;
                if (num > 50)
                {
                    MessageBox.Show("congratz" + " " + n1 + " " + "you win");
                }
                else
                {
                    MessageBox.Show("you lose " + " " + n1);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            n = random.Next(5, 27);
            num += n;

            numSt = n.ToString();

            count++;
            this.button9.Enabled = false;
            this.button9.Text = numSt;
            if (count == 3)
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;

                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button2.Enabled = false;
                if (num > 50)
                {
                    MessageBox.Show("congratz" + " " + n1 + " " + "you win");
                }
                else
                {
                    MessageBox.Show("you lose " + " " + n1);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)

        {
            num = 0;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = random.Next(5, 27);
            num += n;
            numSt = n.ToString();
            


            count++;
            this.button1.Enabled = false;
            this.button1.Text = numSt;
            if(count==3)
            {
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;

                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
                this.button9.Enabled = false;
            
                if (num>50)
                {
                    MessageBox.Show("congratz" + " " + n1 + " " + "you win");
                }
                else
                {
                    MessageBox.Show("you lose " + " " + n1 );
                }
            }
            

        }
    }
}
