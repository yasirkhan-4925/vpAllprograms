using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Tulpep.NotificationWindow;

namespace sendSms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }  

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.Show();
            this.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            String URI = "https://sendpk.com" +
"/api/sms.php?" +
"username=" + "923499811527" +
"&password=" + "yasirkhan4922" +
"&sender=" + "SMS" +
"&mobile=" + textBox1.Text +
"&message=" + Uri.UnescapeDataString(richTextBox1.Text);
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            try
            {


                /* var number = textBox1.Text;
                 var message = richTextBox1.Text;
                 var client = new HttpClient();
                 var result = await client.GetAsync(); */
                if (textBox1.Text != "" || richTextBox1.Text != "")
                {
                    WebRequest req = WebRequest.Create(URI);
                    WebResponse resp = req.GetResponse();
                    var sr = new System.IO.StreamReader(resp.GetResponseStream());
                    sr.ReadToEnd().Trim();

                    PopupNotifier popup = new PopupNotifier();
                    popup.TitleText = "Message";
                    popup.ContentText = "Successfull sent!";
                    popup.Popup();
                }
                else
                {
                    MessageBox.Show("please fill relavent fields");
                }







            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
