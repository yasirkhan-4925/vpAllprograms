using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marksheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
            this.Hide();
            string st_name = textBox1.Text;
            double urdu, coa, dbms, de, dsalgo, vp;
            st_name = textBox1.Text;

            urdu = Convert.ToDouble(textBox2.Text);
            coa = Convert.ToDouble(textBox3.Text);
            dbms = Convert.ToDouble(textBox4.Text);
            de = Convert.ToDouble(textBox5.Text);
            dsalgo = Convert.ToDouble(textBox6.Text);
            vp = Convert.ToDouble(textBox7.Text);
            double total,percentage;
            total = urdu + coa + de + dsalgo + vp;
            percentage = (total / 600) * 100;
            obj.label1.Text = "student name " +st_name+ "\n\n\n" +"vp" + vp + "\n\n\n" + "coa" + coa + "\n\n\n" + "de" + de + "\n\n\n" + "dsalgo" + dsalgo + "\n\n\n" + "urdu" + urdu;
            obj.textBox1.Text = total + "";
            obj.textBox2.Text = percentage + "";






        }
    }
}
