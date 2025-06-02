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
    public partial class CSharpe_Form1 : Form
    {
        public CSharpe_Form1(int userID)
        {
            InitializeComponent();
        }

        private void CSharpe_Form1_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
