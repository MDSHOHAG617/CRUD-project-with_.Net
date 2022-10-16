using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;



namespace first_tesy_app
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pass_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MD_SHOHAG\\SQLEXPRESS01;Initial Catalog=\"User Registration\";Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[userreg] ([user],[pass]) VALUES ('" + namebox.Text + "','" + passbox.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            if (namebox.Text == "" || passbox.Text == "")
            {
                MessageBox.Show("User name or Password is Invalid!!!");
            }
            else
            {

                mainFrame mainFrame = new mainFrame();
                mainFrame.Show();
                Hide();
                MessageBox.Show("succesfully Registered");
            }
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();

        }
    }
}
