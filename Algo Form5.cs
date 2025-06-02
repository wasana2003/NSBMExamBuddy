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
    public partial class Algo_Form5 : Form
    {
        private int userID;

        public Algo_Form5(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        public Algo_Form5()
        {
        }

        private void Algo_Form5_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void algoQ5btn1_Click(object sender, EventArgs e)
        {

            int submoduleID = 62;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void algoQ5btn2_Click(object sender, EventArgs e)
        {

            int submoduleID = 63;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void algoQ5btn3_Click(object sender, EventArgs e)
        {

            int submoduleID = 64;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void algoQ5btn4_Click(object sender, EventArgs e)
        {

            int submoduleID = 65;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }
    }
}
