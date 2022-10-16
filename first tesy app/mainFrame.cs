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

namespace first_tesy_app
{
    public partial class mainFrame : Form
    {
        public mainFrame()
        {
            InitializeComponent();
        }

        private void mainFrame_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MD_SHOHAG\\SQLEXPRESS01;Initial Catalog=CRUD_table;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into UserCRUD_Table values (@ID,@Name,@Age)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(id.Text));
            cmd.Parameters.AddWithValue("@Name", (name.Text));
            cmd.Parameters.AddWithValue("@Age", double.Parse(age.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully data inserted");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MD_SHOHAG\\SQLEXPRESS01;Initial Catalog=CRUD_table;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update UserCRUD_Table set Name = @Name, Age=@Age where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(id.Text));
            cmd.Parameters.AddWithValue("@Name", (name.Text));
            cmd.Parameters.AddWithValue("@Age", double.Parse(age.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully data Updated");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MD_SHOHAG\\SQLEXPRESS01;Initial Catalog=CRUD_table;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete UserCRUD_Table  where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(id.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully data Deleted");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MD_SHOHAG\\SQLEXPRESS01;Initial Catalog=CRUD_table;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from UserCRUD_Table where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(id.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            funDrawing funDrawing = new funDrawing();
            funDrawing.Show();
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
