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
    public partial class User_Progress : Form
    {
        public User_Progress(int userID)
        {
            InitializeComponent();
        }

        private void User_Progress_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true; // for the whole form
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\OneDrive\Documents\NSBMExamBuddy.mdf;Integrated Security=True;Connect Timeout=30";

            string query = "SELECT SubmoduleID, Score, DateTaken FROM UserScores WHERE ID = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // Use the current user's ID (assuming you stored it at login)
                cmd.Parameters.AddWithValue("@id", Login.CurrentUser.ID); // replace with correct property if named differently

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true; //  Make sure the data can't be edited

            }
        }


    }
}
