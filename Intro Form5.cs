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
    public partial class Intro_Form5 : Form
    {
        public Intro_Form5(int userID)
        {
            InitializeComponent();
        }

        private void Intro_Form5_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void introQ5btn1_Click(object sender, EventArgs e)
        {

            int submoduleID = 105;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void introQ5btn2_Click(object sender, EventArgs e)
        {

            int submoduleID = 106;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }
    }
}
