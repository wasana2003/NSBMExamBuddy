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
    public partial class MATHS_Form5 : Form
    {
        public MATHS_Form5()
        {
            InitializeComponent();
        }

        private void MATHS_Form5_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void mathsQ5btn1_Click(object sender, EventArgs e)
        {

            int submoduleID = 44;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void mathsQ5btn2_Click(object sender, EventArgs e)
        {

            int submoduleID = 45;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void mathsQ5btn3_Click(object sender, EventArgs e)
        {

            int submoduleID = 46;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }
    }
}
