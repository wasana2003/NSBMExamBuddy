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
    public partial class Intro_Form2 : Form
    {
        private int userID;

        public Intro_Form2(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        public Intro_Form2()
        {
        }

        private void displayuser_Click(object sender, EventArgs e)
        {

        }

        private void Intro_Form2_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void introQ1btn1_Click(object sender, EventArgs e)
        {

            int submoduleID = 93;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void introQ2btn2_Click(object sender, EventArgs e)
        {

            int submoduleID = 94;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void introQ2btn3_Click(object sender, EventArgs e)
        {

            int submoduleID = 95;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void introQ2btn4_Click(object sender, EventArgs e)
        {

            int submoduleID = 96;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
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
