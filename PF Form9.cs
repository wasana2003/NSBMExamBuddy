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
    public partial class PF_Form9 : Form
    {
        public PF_Form9(int userID)
        {
            InitializeComponent();
        }

        private void PF_Form9_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void pfQ8btn1_Click(object sender, EventArgs e)
        {

            int submoduleID = 29;
            int userID = CurrentUser.ID;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID);
            quiz.Show();
            this.Hide();
        }
    }
}
