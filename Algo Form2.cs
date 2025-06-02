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
    public partial class Algo_Form2 : Form
    {
        private int userID;

        public Algo_Form2(int userID)
        {
            InitializeComponent();
            this.userID = userID;

        }

        public Algo_Form2()
        {
        }

        private void Algo_Form2_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void algoQ2btn1_Click(object sender, EventArgs e)
        {

            int submoduleID = 50;
            int userID = CurrentUser.ID;
            int moduleID = 16;


            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }

        private void algoQ2btn2_Click(object sender, EventArgs e)
        {

            int submoduleID = 51;
            int userID = CurrentUser.ID;
            int moduleID = 16;


            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }

        private void algoQ2btn3_Click(object sender, EventArgs e)
        {

            int submoduleID = 52;
            int userID = CurrentUser.ID;
            int moduleID = 16;


            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID,moduleID);
            quiz.Show();
            this.Hide();
        }

        private void algoQ2btn4_Click(object sender, EventArgs e)
        {

            int submoduleID = 53;
            int userID = CurrentUser.ID;
            int moduleID = 16;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
