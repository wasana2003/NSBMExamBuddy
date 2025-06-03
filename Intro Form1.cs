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
    public partial class Intro_Form1 : Form
    {
        private int userID;

        public Intro_Form1(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        public Intro_Form1()
        {
        }

        private void introQ1btn1_Click(object sender, EventArgs e)
        {

            int submoduleID = 89;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();

        }

        private void Intro_Form1_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void introQ1btn2_Click(object sender, EventArgs e)
        {

            int submoduleID = 90;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void Intro_Form2_Load(object sender, EventArgs e)
        {
        }

        private void introQ1btn3_Click(object sender, EventArgs e)
        {
            int submoduleID = 91;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();

        }

        private void introQ1btn4_Click(object sender, EventArgs e)
        {
            int submoduleID = 92;
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