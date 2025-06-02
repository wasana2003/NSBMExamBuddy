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
using static NSBMExamBuddy.Login;

namespace NSBMExamBuddy
{
    public partial class View_User_Progress : Form
    {
        private SqlConnection con;
        private string query;

        public View_User_Progress()
        {
            InitializeComponent();

        }

        private void View_User_Progress_Load(object sender, EventArgs e)
        {

            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;
                      AttachDbFilename=C:\Users\user\OneDrive\Documents\NSBMExamBuddy.mdf;
                      Integrated Security=True;Connect Timeout=30;";

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "SELECT * FROM UserScores";  // No WHERE clause
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;  //  Display full table

                dataGridView1.ReadOnly = true; //  Make sure the data can't be edited

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\OneDrive\Documents\NSBMExamBuddy.mdf;Integrated Security=True;Connect Timeout=30;";

            using (SqlConnection con = new SqlConnection(conStr))
            {
                string query = "SELECT Name FROM [User] WHERE ID = @UserID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", enteruserid.Text);

                con.Open();
                var result = cmd.ExecuteScalar(); // Returns the first column of the first row

                if (result != null)
                {
                    displayusername.Text = $"User Name: {result.ToString()}";
                }
                else
                {
                    
                    displayusername.Text = "User not found.";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Admin_Dashboard dashboard = new Admin_Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
