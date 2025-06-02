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
    public partial class CA_Form8 : Form
    {
        private int userID;

        public CA_Form8()
        {
        }

        public CA_Form8(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void CA_Form8_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }
    }
}
