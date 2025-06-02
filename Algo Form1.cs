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
    public partial class ALGO_Form1 : Form
    {
        private int userID;

        public ALGO_Form1(int userID)
        {
            InitializeComponent();
            this.userID = userID;

        }

        public ALGO_Form1()
        {
        }

        private void ALGO_Form1_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User: , {CurrentUser.Name}";

        }

        private void algoQ1btn1_Click(object sender, EventArgs e)
        {

            int submoduleID = 47;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void algoQ1btn2_Click(object sender, EventArgs e)
        {

            int submoduleID = 48;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void algoQ1btn3_Click(object sender, EventArgs e)
        {

            int submoduleID = 49;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }
    }
}
