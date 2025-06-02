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
    public partial class Login : Form
    {

        string username;
        string password;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        public void loginbtn_Click(object sender, EventArgs e)
        {
            username = userName.Text.Trim();
            password = pw.Text.Trim(); 
            bool isAdmin = adminradio.Checked;
            bool isUser = Userradio.Checked;

            if (isAdmin)
            {
                // Hardcoded admin login for demo
                if (username == "admin" && password == "admin1234")
                {
                    MessageBox.Show("Admin login successful.");
                    Admin_Dashboard adminDashB = new Admin_Dashboard();
                    adminDashB.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid admin credentials.");
                }
            }
            else if (isUser)
            {
                // User login logic
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\OneDrive\Documents\NSBMExamBuddy.mdf;Integrated Security=True;Connect Timeout=30");
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM [User] WHERE Name = @Name AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Name", username);
                    cmd.Parameters.AddWithValue("@Password", password); // If hashed, use ComputeSha256Hash(password)

                    int result = (int)cmd.ExecuteScalar();

                    if (result > 0)
                    {
                        // ✅ Retrieve the user ID
                        string idQuery = "SELECT ID FROM [User] WHERE Name = @Name";
                        SqlCommand idCmd = new SqlCommand(idQuery, con);
                        idCmd.Parameters.AddWithValue("@Name", username);
                        int userID = Convert.ToInt32(idCmd.ExecuteScalar());

                        // ✅ Set current user
                        CurrentUser.ID = userID;
                        CurrentUser.Name = username;

                        MessageBox.Show("User login successful.");
                        Dashboard dashboard = new Dashboard(userID); // Your module dashboard form
                        dashboard.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Invalid user credentials. Please sign up if not registered.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during login: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select either Admin or User.");
            }

        }

        public static class CurrentUser
        {
            public static int ID;
            public static string Name;

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
          


        }

        private void pw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
