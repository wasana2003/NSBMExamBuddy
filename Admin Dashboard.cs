using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NSBMExamBuddy
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userProgress_Click(object sender, EventArgs e)
        {
            View_User_Progress view_User_Progress = new View_User_Progress();
            view_User_Progress.Show();
            this.Hide();
        }

        private void userdetails_Click(object sender, EventArgs e)
        {
            View_User_Info view_User_Info = new View_User_Info();   
            view_User_Info.Show();
            this.Hide();
        }
    }
}
