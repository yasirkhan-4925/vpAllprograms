using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Database_Crud
{
    public partial class Form2 : Form
    {
       

        MySqlConnection con = new MySqlConnection("server=localhost; user id=root ;password =yasirkhan4925;database=cnic_request");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            viewGridview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" && textBox4.Text != "" && textBox4.Text != "")
            {
                try
                {
                    string query2 = "select * from cnicrequest where RecieptNo=@RecieptNo";
                    MySqlCommand cmd2 = new MySqlCommand(query2, con);
                    cmd2.Parameters.AddWithValue("@RecieptNo",textBox1.Text);
                    con.Open();
                     MySqlDataReader dr= cmd2.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        MessageBox.Show(textBox1.Text + "Id already exist", "failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }
                    else
                    {
                        con.Close();
                        string query = "INSERT INTO cnicrequest VALUES(@RecieptNo,@Name,@FatherName,@Gender,@CountryOfStay,@IdentityNumber,@DateOfBirth)";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@RecieptNo", Convert.ToInt32(textBox1.Text));
                        cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                        cmd.Parameters.AddWithValue("@FatherName", textBox3.Text);
                        cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
                        cmd.Parameters.AddWithValue("@CountryOfStay", textBox4.Text);
                        cmd.Parameters.AddWithValue("@IdentityNumber", textBox5.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Text);

                        con.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("Record Successfully saved in Database", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearfields();
                            viewGridview();
                        }
                        else
                        {
                            MessageBox.Show("data not inserted", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }
            else
            {
                MessageBox.Show("please fill all fields");
            }


        }
        void viewGridview()
        {
            string query = "select * from cnicrequest";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        void clearfields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" && textBox4.Text != "" && textBox4.Text != "")
            {
                try
                {
                    string query = "update cnicrequest set RecieptNo=@RecieptNo,Name=@Name,FatherName=@FatherName,Gender=@Gender,CountryOfStay=@CountryOfStay,IndentityNumber=@IdentityNumber,DateOfBirth=@DateOfBirth where RecieptNo=@RecieptNo";
                    MySqlCommand cmd = new MySqlCommand(query,con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@RecieptNo", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@FatherName", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@CountryOfStay", textBox4.Text);
                    cmd.Parameters.AddWithValue("@IdentityNumber", textBox5.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Text);

                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearfields();
                        viewGridview();
                    }
                    else
                    {
                        MessageBox.Show("There is a problem in updating data", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("please fill all fields");
            }
        }







        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("dont click here click on the left corner of row to get data","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
         
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "delete from cnicrequest where RecieptNo=@RecieptNo";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@RecieptNo", textBox1.Text);


            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Deleted  Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearfields();
                viewGridview();
            }
            else
            {
                MessageBox.Show("There is a problem in deleting  data or inter reciept id to delete", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {

                string query = "select * from cnicrequest where Name like @Name";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@Name", textBox6.Text.Trim()+"%");
                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    dataGridView1.DataSource = data;
                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            else
            {
                viewGridview();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            viewGridview();
        }
    }
}
