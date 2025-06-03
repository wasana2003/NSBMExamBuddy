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
    public partial class Computer_Architechture : Form
    {
        private int userID;

        public Computer_Architechture()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ca1btn_Click(object sender, EventArgs e)
        {
            CA_Form1 caForm1 = new CA_Form1();
            caForm1.Show();
            this.Hide();
        }

        private void ca2btn_Click(object sender, EventArgs e)
        {
            CA_Form2 caForm2 = new CA_Form2();
            caForm2.Show();
            this.Hide();
        }

        private void ca3btn_Click(object sender, EventArgs e)
        {
            CA_Form3 caForm3 = new CA_Form3();
            caForm3.Show();
            this.Hide();
        }

        private void ca4btn_Click(object sender, EventArgs e)
        {
            CA_Form4 caForm4 = new CA_Form4();
            caForm4.Show();
            this.Hide();
        }

        private void ca5btn_Click(object sender, EventArgs e)
        {
            CA_Form5 caForm5 = new CA_Form5();
            caForm5.Show();
            this.Hide();
        }

        private void ca6btn_Click(object sender, EventArgs e)
        {
            CA_Form6 caForm6 = new CA_Form6();
            caForm6.Show();
            this.Hide();
        }

        private void ca7btn_Click(object sender, EventArgs e)
        {
            CA_Form7 caForm7 = new CA_Form7();
            caForm7.Show();
            this.Hide();
        }

        private void ca8btn_Click(object sender, EventArgs e)
        {
            CA_Form8 caForm8 = new CA_Form8();
            caForm8.Show();
            this.Hide();
        }

        private void Computer_Architechture_Load(object sender, EventArgs e)
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
