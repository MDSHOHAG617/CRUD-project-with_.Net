using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace first_tesy_app
{
    public partial class loginForm : Form
    {
        /* string ConStr = @"Data Source=MD_SHOHAG\SQLEXPRESS01;Initial Catalog=""User Registration"";Integrated Security=True";
        SqlConnection con;
        SqlDataReader dr;*/

        public loginForm()
        {
            InitializeComponent();

            /*con = new SqlConnection(ConStr);*/
           
        }

        private void register_Click(object sender, EventArgs e)
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
                MessageBox.Show("succesfully Logedin");
            }



            /*  string query = @"SELECT [user],[pass] FROM [dbo].[userreg] Where user='"+namebox.Text+"' AND pass='"+passbox.Text+"'";
              con.Open();
              SqlCommand cmd = new SqlCommand(query,con);
              dr = cmd.ExecuteReader();

              if (dr.Read()) 
              {
                  mainFrame mainFrame = new mainFrame();
                  mainFrame.Show();
                  Hide();
                  MessageBox.Show("succesfully logedin");
              }
              else
              {
                  MessageBox.Show("User name or Password is Invalid!!!");
              }*/

        }

        private void label1_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm RegisterForm = new RegisterForm();
            RegisterForm.Show();
            Hide();
        }
    }
}
