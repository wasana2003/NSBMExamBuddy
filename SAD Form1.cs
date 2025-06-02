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
    public partial class SAD_Form1 : Form
    {
        private int userID;

        public SAD_Form1(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void SAD_Form1_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void sadQ1btn1_Click(object sender, EventArgs e)
        {

        }
    }
}
