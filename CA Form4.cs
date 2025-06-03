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
    public partial class CA_Form4 : Form
    {
        private int userID;

        public CA_Form4()
        {
        }

        public CA_Form4(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void CA_Form4_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void caQ4btn1_Click(object sender, EventArgs e)
        {
            int submoduleID = 212;
            int userID = CurrentUser.ID;
            int moduleID = 54;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }

        private void caQ4btn2_Click(object sender, EventArgs e)
        {
            int submoduleID = 212;
            int userID = CurrentUser.ID;
            int moduleID = 54;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }

        private void caQ4btn3_Click(object sender, EventArgs e)
        {
            int submoduleID = 212;
            int userID = CurrentUser.ID;
            int moduleID = 54;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }

        private void caQ4btn4_Click(object sender, EventArgs e)
        {
            int submoduleID = 212;
            int userID = CurrentUser.ID;
            int moduleID = 54;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard(userID);
            dashboard.Show();
            this.Hide();
        }
    }
}
