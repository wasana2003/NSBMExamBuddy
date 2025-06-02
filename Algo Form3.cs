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
    public partial class Algo_Form3 : Form
    {
        private int userID;

        public Algo_Form3(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        public Algo_Form3()
        {
        }

        private void Algo_Form3_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void algoQ3btn1_Click(object sender, EventArgs e)
        {

            int submoduleID = 54;
            int userID = CurrentUser.ID;
            int moduleID = 17;


            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }

        private void algoQ3btn2_Click(object sender, EventArgs e)
        {

            int submoduleID = 55;
            int userID = CurrentUser.ID;
            int moduleID = 17;


            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }

        private void algoQ3btn3_Click(object sender, EventArgs e)
        {

            int submoduleID = 56;
            int userID = CurrentUser.ID;
            int moduleID = 17;


            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID,moduleID);
            quiz.Show();
            this.Hide();
        }

        private void algoQ3btn4_Click(object sender, EventArgs e)
        {

            int submoduleID = 57;
            int userID = CurrentUser.ID;
            int moduleID = 17;


            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID,moduleID);
            quiz.Show();
            this.Hide();
        }
    }
}
