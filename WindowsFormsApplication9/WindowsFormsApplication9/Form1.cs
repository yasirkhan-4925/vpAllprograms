using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form

    {
        string hour, minu, secnd;
        string user_hour, user_minute;
        SoundPlayer player;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            user_hour = comboBox1.Text;
            user_minute = comboBox2.Text;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            hour = DateTime.Now.Hour+"";
            minu = DateTime.Now.Minute+"";
            secnd = DateTime.Now.Second+"";
            label2.Text = hour;
            label3.Text = minu;
            label4.Text = secnd;
            if(hour==user_hour&&user_minute==minu)
            {
                timer1.Stop();
                try
                {

                    player = new SoundPlayer();
                    player.SoundLocation = @"C:\Users\ND.COM\Downloads\Music\beep-04.wav";
                    player.PlayLooping();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "error");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            player.Stop();
            

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }
    }
}
