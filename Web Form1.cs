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
    public partial class Web_Form1 : Form
    {
        public Web_Form1(int userID)
        {
            InitializeComponent();
        }

        private void Web_Form1_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void webQ1btn1_Click(object sender, EventArgs e)
        {

            int submoduleID = 69;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void webQ1btn2_Click(object sender, EventArgs e)
        {

            int submoduleID = 70;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void webQ1btn3_Click(object sender, EventArgs e)
        {

            int submoduleID = 71;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void webQ1btn4_Click(object sender, EventArgs e)
        {

            int submoduleID = 72;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }
    }
}
