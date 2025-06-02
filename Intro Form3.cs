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
    public partial class Intro_Form3 : Form
    {
        private int userID;

        public Intro_Form3(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        public Intro_Form3()
        {
        }

        private void Intro_Form3_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void introQ3btn1_Click(object sender, EventArgs e)
        {

            int submoduleID = 97;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void introQ3btn2_Click(object sender, EventArgs e)
        {

            int submoduleID = 98;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void introQ3btn3_Click(object sender, EventArgs e)
        {

            int submoduleID = 99;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void introQ3btn4_Click(object sender, EventArgs e)
        {

            int submoduleID = 100;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }
    }
}
