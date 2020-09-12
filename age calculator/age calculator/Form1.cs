using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_calculator
{
    public partial class Form1 : Form
    {
        int age;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            DateTime dob = dateTimePicker1.Value;
            if(current.Year>dob.Year)
            {
                age = current.Year - dob.Year;
                textBox2.Text = age + "";  
            }
            else
            {
                age--;
                textBox2.Text = age + "";
            }
        }
    }
}
