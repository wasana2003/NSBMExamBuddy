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
    public partial class System_Analysis_and_Design : Form
    {
        public System_Analysis_and_Design()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void sad1btn_Click(object sender, EventArgs e)
        {
            SAD_Form1 sadForm1 = new SAD_Form1();
            sadForm1.Show();
            this.Hide();
        }

        private void sad2btn_Click(object sender, EventArgs e)
        {
            SAD_Form2 sadForm2 = new SAD_Form2();
            sadForm2.Show();
            this.Hide();
        }

        private void sad3btn_Click(object sender, EventArgs e)
        {
            SAD_Form3 sadForm3 = new SAD_Form3();
            sadForm3.Show();
            this.Hide();
        }

        private void sad4btn_Click(object sender, EventArgs e)
        {
            SAD_Form4 sadForm4 = new SAD_Form4();
            sadForm4.Show();
            this.Hide();
        }

        private void sad5btn_Click(object sender, EventArgs e)
        {
            SAD_Form5 sadForm5 = new SAD_Form5();
            sadForm5.Show();
            this.Hide();
        }

        private void sad6btn_Click(object sender, EventArgs e)
        {
            SAD_Form6 sadForm6 = new SAD_Form6();
            sadForm6.Show();
            this.Hide();
        }

        private void System_Analysis_and_Design_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }
    }
}
