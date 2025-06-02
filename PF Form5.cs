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
    public partial class PF_Form5 : Form
    {
        private int userID;

        public PF_Form5()
        {
        }

        public PF_Form5(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void PF_Form5_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void pfQ5tn1_Click(object sender, EventArgs e)
        {
            int submoduleID = 17;
            int userID = CurrentUser.ID;
            int moduleID = 5;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }

        private void pfQ5btn2_Click(object sender, EventArgs e)
        {
            int submoduleID = 18;
            int userID = CurrentUser.ID;
            int moduleID = 5;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }

        private void pfQ5btn3_Click(object sender, EventArgs e)
        {
            int submoduleID = 19;
            int userID = CurrentUser.ID;
            int moduleID = 5;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }
    }
}
