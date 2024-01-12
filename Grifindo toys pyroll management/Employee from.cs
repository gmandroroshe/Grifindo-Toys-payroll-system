using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add sql databse 
using System.Data.Sql;
using System.Data.SqlClient;


namespace Grifindo_toys_pyroll_management
{
    public partial class Employee_from : Form
    {
        //Database connection 
        string con_string = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Desktop\C# projects\Grifindo toys pyroll management\Grifindo toys pyroll management\Database.mdf;Integrated Security=True";

        public Employee_from()
        {

            InitializeComponent();
            //center screen 
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Insert Button 
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand
                ("insert into employee(eid,name,address,dob,bsal,allowance,otrate) values(@eid,@name,@address,@dob,@bsal,@allowance,@otrate)", con);
                mycmd.Parameters.AddWithValue("@eid", textBox1.Text);
                mycmd.Parameters.AddWithValue("@name", textBox2.Text);
                mycmd.Parameters.AddWithValue("@address", textBox3.Text);
                mycmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                mycmd.Parameters.AddWithValue("@bsal", textBox4.Text);
                mycmd.Parameters.AddWithValue("@otrate", textBox5.Text);
                mycmd.Parameters.AddWithValue("@allowance", textBox6.Text);

                mycmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update button 
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand
                ("update employee set  name=@name, address=@address ,dob=@dob ,bsal=@bsal ,otrate=@otrate,allowance=@allowance where eid=@eid", con);
                mycmd.Parameters.AddWithValue("@eid", textBox1.Text);
                mycmd.Parameters.AddWithValue("@name", textBox2.Text);
                mycmd.Parameters.AddWithValue("@address", textBox3.Text);
                mycmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                mycmd.Parameters.AddWithValue("@bsal", textBox4.Text);
                mycmd.Parameters.AddWithValue("@otrate", textBox5.Text);
                mycmd.Parameters.AddWithValue("@allowance", textBox6.Text);

                mycmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //delete button 
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("delete from employee where eid=@eid;", con);
                mycmd.Parameters.AddWithValue("@eid", textBox1.Text);
                mycmd.Parameters.AddWithValue("@name", textBox2.Text);
                mycmd.Parameters.AddWithValue("@address", textBox3.Text);
                mycmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                mycmd.Parameters.AddWithValue("@bsal", textBox4.Text);
                mycmd.Parameters.AddWithValue("@allowance", textBox5.Text);

                mycmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //serch button 
            try
            {
                SqlConnection con = new SqlConnection(con_string);
                con.Open();
                SqlCommand mycmd = new SqlCommand("select*from Employee", con);
                SqlDataAdapter ad = new SqlDataAdapter(mycmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show("Error");
            }
        }

        private void Employee_from_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //exit button 
            var result = MessageBox.Show("Are you shour do you wantto Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Back button 
            From_main frm = new From_main();
            frm.Show();
            this.Hide();
        }
    }
}
