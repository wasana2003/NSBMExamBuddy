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
    public partial class CSharpe_Form6 : Form
    {
        public CSharpe_Form6()
        {
            InitializeComponent();
        }

        private void CSharpe_Form6_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void csharpeQ6btn4_Click(object sender, EventArgs e)
        {

        }
    }
}
