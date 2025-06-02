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
    public partial class Algo_Form6 : Form
    {
        private int userID;

        public Algo_Form6(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        public Algo_Form6()
        {
        }

        private void Algo_Form6_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void algoQ6btn1_Click(object sender, EventArgs e)
        {

            int submoduleID = 66;
            int userID = CurrentUser.ID;
            int moduleID = 20;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID,moduleID);
            quiz.Show();
            this.Hide();
        }

        private void algoQ6btn2_Click(object sender, EventArgs e)
        {
            int submoduleID = 67;
            int userID = CurrentUser.ID;
            int moduleID = 20;


            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID,moduleID);
            quiz.Show();
            this.Hide();

        }

        private void algoQ6btn3_Click(object sender, EventArgs e)
        {

            int submoduleID = 68;
            int userID = CurrentUser.ID;
            int moduleID = 20;


            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID, moduleID);
            quiz.Show();
            this.Hide();
        }
    }
}
