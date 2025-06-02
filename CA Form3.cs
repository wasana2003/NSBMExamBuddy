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
    public partial class CA_Form3 : Form
    {
        private int userID;

        public CA_Form3()
        {
        }

        public CA_Form3(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void CA_Form3_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void caQ3btn1_Click(object sender, EventArgs e)
        {
            int submoduleID = 212;
            int userID = CurrentUser.ID;
            int moduleID = 54;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }

        private void caQ3btn2_Click(object sender, EventArgs e)
        {
            int submoduleID = 212;
            int userID = CurrentUser.ID;
            int moduleID = 54;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }

        private void caQ3btn3_Click(object sender, EventArgs e)
        {
            int submoduleID = 212;
            int userID = CurrentUser.ID;
            int moduleID = 54;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }

        private void caQ3btn4_Click(object sender, EventArgs e)
        {
            int submoduleID = 212;
            int userID = CurrentUser.ID;
            int moduleID = 54;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }
    }
}
