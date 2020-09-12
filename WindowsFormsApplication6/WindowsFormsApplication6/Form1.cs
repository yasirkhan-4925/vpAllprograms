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

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        SoundPlayer player;
      
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime pctime = DateTime.Now;
            DateTime usertime = dateTimePicker1.Value;
            
            
            if(pctime.Hour==usertime.Hour&&pctime.Minute==usertime.Minute&&pctime.Second==usertime.Second)
            {
               
                try
                {


                     player = new SoundPlayer();
                    player.SoundLocation = @"C:\Users\ND.COM\Downloads\Music\beep-04.wav";
                    player.PlayLooping();
                    
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"error");
                }





            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
          

            
            
            label1.Text = "alarm running";
            label2.Text = Convert.ToString("alarm set for"+""+dateTimePicker1.Value);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            player.Stop();
            label1.Text = "";
            label2.Text = "";
            
            

            
            
            
        }
    }
}
