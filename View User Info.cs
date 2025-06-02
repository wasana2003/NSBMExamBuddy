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

namespace NSBMExamBuddy
{
    public partial class View_User_Info : Form
    {
        public View_User_Info()
        {
            InitializeComponent();
        }

        private void displayusername_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\OneDrive\Documents\NSBMExamBuddy.mdf;Integrated Security=True;Connect Timeout=30;";

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "SELECT Name, Email, Stream FROM [User] WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", enteruserid.Text);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    displayUname.Text = $"User Name : {reader["Name"].ToString()}";
                    displayEmail.Text = $"Email : {reader["Email"].ToString()}";
                    displayStream.Text = $"Stream : {reader["Stream"].ToString()}";
                }
                else
                {
                    displayUname.Text = "User not found.";
                    displayEmail.Text = "";
                    displayStream.Text = "";
                }

                reader.Close();
            }
        }

        private void enteruserid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private  void View_User_Info_Load(object sender, EventArgs e)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
                      AttachDbFilename=C:\Users\user\OneDrive\Documents\NSBMExamBuddy.mdf;
                      Integrated Security=True;Connect Timeout=30;";

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "SELECT ID FROM [User]";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewinfo.DataSource = dt;  //  Display full table

                dataGridViewinfo.ReadOnly = true; //  Make sure the data can't be edited

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Dashboard dashboard = new Admin_Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
