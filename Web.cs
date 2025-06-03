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
    public partial class Web : Form
    {
        private int userID;

        public Web()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void web1btn_Click(object sender, EventArgs e)
        {
            Web_Form1 webForm1 = new Web_Form1();
            webForm1.Show();
            this.Hide();

        }

        private void web2btn_Click(object sender, EventArgs e)
        {
            Web_Form2 webForm2 = new Web_Form2();
            webForm2.Show();
            this.Hide();
        }

        private void web3btn_Click(object sender, EventArgs e)
        {
            Web_Form3 webForm3 = new Web_Form3();
            webForm3.Show();
            this.Hide();
        }

        private void web4btn_Click(object sender, EventArgs e)
        {
            Web_Form4 webForm4 = new Web_Form4();
            webForm4.Show();
            this.Hide();
        }

        private void web5btn_Click(object sender, EventArgs e)
        {
            Web_Form5 webForm5 = new Web_Form5();
            webForm5.Show();
            this.Hide();
        }

        private void Web_Load(object sender, EventArgs e)
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
