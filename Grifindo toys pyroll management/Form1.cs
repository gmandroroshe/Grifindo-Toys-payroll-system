using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_toys_pyroll_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //center screen 
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private int incorrectAttempts = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            //login Button 
            if (txtusr.Text == "Admin" && txtpaw.Text == "123")
            {
                // Correct credentials
                button1.BackColor = Color.Green;
                From_main frm = new From_main();
                frm.Show();
                this.Hide();
            }
            else
            {
                // Incorrect credentials
                incorrectAttempts++;

                if (incorrectAttempts >= 5) //Exit 
                {
                    MessageBox.Show("Too many incorrect attempts. The application will now exit.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
                else
                {
                    button1.BackColor = Color.Red;
                    MessageBox.Show("Incorrect Password. Please try again. Attempts left: {5 - incorrectAttempts}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
