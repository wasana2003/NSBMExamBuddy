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
    public partial class DBMS_Form2 : Form
    {
        private int userID;

        public DBMS_Form2(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        public DBMS_Form2()
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DBMS_Form2_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard(userID);
            dashboard.Show();
            this.Hide();
        }
    }
}
