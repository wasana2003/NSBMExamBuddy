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
    public partial class PF_Form1 : Form
    {
        private int userID;

        public PF_Form1(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void PF_Form1_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }


        private void pfQ1btn1_Click(object sender, EventArgs e)
        {
            int submoduleID = 1;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void pfQ1btn2_Click(object sender, EventArgs e)
        {
            int submoduleID = 2;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();

        }

        private void pfQ1btn3_Click(object sender, EventArgs e)
        {

            int submoduleID = 3;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void pfQ1btn4_Click(object sender, EventArgs e)
        {

            int submoduleID = 4;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }
    }
}
