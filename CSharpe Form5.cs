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
    public partial class CSharpe_Form5 : Form
    {
        private int userID;

        public CSharpe_Form5()
        {
        }

        public CSharpe_Form5(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void CSharpe_Form5_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }
    }
}
