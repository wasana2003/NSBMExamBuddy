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
    public partial class Database_Management_Systerm : Form
    {
        public Database_Management_Systerm()
        {
            InitializeComponent();
        }

        private void dbms1btn_Click(object sender, EventArgs e)
        {
            DBMS_Form1 dbmsForm1 = new DBMS_Form1();
            dbmsForm1.Show();
            this.Hide();
        }

        private void dbms2btn_Click(object sender, EventArgs e)
        {
            DBMS_Form2 dbmsForm2 = new DBMS_Form2();
            dbmsForm2.Show();
            this.Hide();
        }

        private void dbms3btn_Click(object sender, EventArgs e)
        {
            DBMS_Form3 dbmsForm3 = new DBMS_Form3();
            dbmsForm3.Show();
            this.Hide();
        }

        private void dbms4btn_Click(object sender, EventArgs e)
        {
            DBMS_Form4 dbmsForm4 = new DBMS_Form4();
            dbmsForm4.Show();
            this.Hide();
        }

        private void dbms5btn_Click(object sender, EventArgs e)
        {
            DBMS_Form5 dbmsForm5 = new DBMS_Form5();
            dbmsForm5.Show();
            this.Hide();
        }

        private void dbms6btn_Click(object sender, EventArgs e)
        {
            DBMS_Form6 dbmsForm6 = new DBMS_Form6();
            dbmsForm6.Show();
            this.Hide();
        }

        private void Database_Management_Systerm_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }
    }
}
