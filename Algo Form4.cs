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
    public partial class Algo_Form4 : Form
    {
        private int userID;

        public Algo_Form4(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        public Algo_Form4()
        {
        }

        private void Algo_Form4_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void algoQ4btn1_Click(object sender, EventArgs e)
        {

            int submoduleID = 58;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void algoQ4btn2_Click(object sender, EventArgs e)
        {

            int submoduleID = 59;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void algoQ4btn3_Click(object sender, EventArgs e)
        {

            int submoduleID = 60;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void algoQ4btn4_Click(object sender, EventArgs e)
        {

            int submoduleID = 61;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }
    }
}
