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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\OneDrive\Documents\NSBMExamBuddy.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Username = textname.Text;
                string Password = textpassword.Text;
                string Confirmpassword = textcpw.Text;
                string Email = textemail.Text;
                string Stream = stream.Text;

                string ConfirmPassword = textcpw.Text; // <-- get value from Confirm Password textbox

                if (Password != ConfirmPassword)
                {
                    MessageBox.Show("Password and Confirm Password do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // prevent execution of registration
                }


                //password validation dnnna one confirm ekt

                string query = "INSERT INTO [User] (Name, Email, Password, Stream) VALUES (@Name, @Email, @Password, @Stream)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", Username);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Stream", Stream);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successful");
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while registering: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}