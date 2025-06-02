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
    public partial class DBMS_Form1 : Form
    {
        public DBMS_Form1(int userID)
        {
            InitializeComponent();
        }

        private void pfQ7btn2_Click(object sender, EventArgs e)
        {
            int submoduleID = 115;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DBMS_Form1_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void dbmsQ1btn1_Click(object sender, EventArgs e)
        {
            int submoduleID = 114;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }

        private void dbmsQ1btn3_Click(object sender, EventArgs e)
        {
            int submoduleID = 116;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }
    }
}
