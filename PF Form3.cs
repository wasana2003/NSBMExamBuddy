using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NSBMExamBuddy.Login;

namespace NSBMExamBuddy
{
    public partial class PF_Form3 : Form
    {
        private int userID;

        public PF_Form3(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        public PF_Form3()
        {
        }

        private void PF_Form3_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User : {CurrentUser.Name}";

        }

        private void pfQ3btn1_Click(object sender, EventArgs e)
        {
            
            int submoduleID = 9;
            int userID = CurrentUser.ID;
            int moduleID = 3;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID , moduleID);
            quiz.Show();
            this.Hide();
        }

        private void pfQ3btn2_Click(object sender, EventArgs e)
        {

            int submoduleID = 10;
            int userID = CurrentUser.ID;
            int moduleID = 3;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }

        private void pfQ3btn3_Click(object sender, EventArgs e)
        {

            int submoduleID = 11;
            int userID = CurrentUser.ID;
            int moduleID = 3;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID ,moduleID);
            quiz.Show();
            this.Hide();
        }

        private void pfQ3btn4_Click(object sender, EventArgs e)
        {

            int submoduleID = 12;
            int userID = CurrentUser.ID;
            int moduleID = 3;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID ,moduleID);
            quiz.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard(userID);
            dashboard.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Programming_Fundamental programming_Fundamental = new Programming_Fundamental();
            programming_Fundamental.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About_Form about_Form = new About_Form();
            about_Form.Show();
            this.Hide();
        }
    }
}
