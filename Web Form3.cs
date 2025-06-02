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
    public partial class Web_Form3 : Form
    {
        public Web_Form3(int userID)
        {
            InitializeComponent();
        }

        private void Web_Form3_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void webQ3btn1_Click(object sender, EventArgs e)
        {

            int submoduleID = 85;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void webQ3btn2_Click(object sender, EventArgs e)
        {

            int submoduleID = 86;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void webQ3btn3_Click(object sender, EventArgs e)
        {

            int submoduleID = 87;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void webQ3btn4_Click(object sender, EventArgs e)
        {

            int submoduleID = 88;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }
    }
}
