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
    public partial class Programming_Fundamental : Form
    {
        private int userID;

        public Programming_Fundamental()
        {
            InitializeComponent();
        }

        public PF_Form1 PF_Form1 { get; private set; }
        public PF_Form2 PF_Form2 { get; private set; }
        public PF_Form3 PF_Form3 { get; private set; }
        public PF_Form4 PF_Form4 { get; private set; }
        public PF_Form5 PF_Form5 { get; private set; }
        public PF_Form6 PF_Form6 { get; private set; }
        public PF_Form7 PF_Form7 { get; private set; }
        public PF_Form8 PF_Form8 { get; private set; }
        public PF_Form9 PF_Form9 { get; private set; }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        //private void Programming_Fundamental_Load(object sender, EventArgs e)
        //{
        //    displayuser.Text = $"User :, {CurrentUser.Name}";
        //}

        private void pf1btn_Click(object sender, EventArgs e)
        {
            PF_Form1 = new PF_Form1(CurrentUser.ID);
            PF_Form1.Show();
            this.Hide();
        }

        private void pf2btn_Click(object sender, EventArgs e)
        {
            PF_Form2 = new PF_Form2(CurrentUser.ID);
            PF_Form2.Show();
            this.Hide();
        }

        private void pf3btn_Click(object sender, EventArgs e)
        {
            PF_Form3 = new PF_Form3(CurrentUser.ID);
            PF_Form3.Show();
            this.Hide();
        }

        private void pf4btn_Click(object sender, EventArgs e)
        {
            PF_Form4 = new PF_Form4(CurrentUser.ID);
            PF_Form4.Show();
            this.Hide();
        }

        private void pf5btn_Click(object sender, EventArgs e)
        {
            PF_Form5 = new PF_Form5(CurrentUser.ID);
            PF_Form5.Show();
            this.Hide();
        }

        private void pf6btn_Click(object sender, EventArgs e)
        {
            PF_Form6 = new PF_Form6(CurrentUser.ID);
            PF_Form6.Show();
            this.Hide();
        }

        private void pf7btn_Click(object sender, EventArgs e)
        {
            PF_Form7 = new PF_Form7(CurrentUser.ID);
            PF_Form7.Show();
            this.Hide();
        }

        private void pf8btn_Click(object sender, EventArgs e)
        {
            PF_Form8 = new PF_Form8(CurrentUser.ID);
            PF_Form8.Show();
            this.Hide();
        }

        private void pf9btn_Click(object sender, EventArgs e)
        {
            PF_Form9 = new PF_Form9(CurrentUser.ID);
            PF_Form9.Show();
            this.Hide();
        }

        private void Programming_Fundamental_Load_1(object sender, EventArgs e)
        {
            displayuser.Text = $"User : {CurrentUser.Name}";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard(userID);
            dashboard.Show();
            this.Hide();
        }

        private void pf3btn_Click_1(object sender, EventArgs e)
        {

        }

        private void displayuser_Click(object sender, EventArgs e)
        {

        }
    }
}
