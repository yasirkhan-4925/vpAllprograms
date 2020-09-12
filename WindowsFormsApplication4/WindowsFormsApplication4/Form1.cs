using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double h = 0, m = 0, s = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if(s>=60)
            {
                m++;
                s = 0;
            }
            if(m>=60)
            {
                h++;
                m = 0;
                s = 0;
                
            }
            label1.Text = h + "";
            label3.Text = m + "";
            label5.Text = s + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        
    }
}
