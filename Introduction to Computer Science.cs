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
    public partial class Introduction_to_Computer_Science : Form
    {
        private int userID;

        public Intro_Form1 Intro_Form1 { get; private set; }
        public Intro_Form2 Intro_Form2 { get; private set; }
        public Intro_Form3 Intro_Form3 { get; private set; }
        public Intro_Form4 Intro_Form4 { get; private set; }
        public Intro_Form5 Intro_Form5 { get; private set; }
        public Intro_Form6 Intro_Form6 { get; private set; }
        public Intro_Form7 Intro_Form7 { get; private set; }

        public Introduction_to_Computer_Science()
        {
            InitializeComponent();
        }

        private void Introduction_to_Computer_Science_Load(object sender, EventArgs e)
        {
          displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void intro1btn_Click(object sender, EventArgs e)
        {
            Intro_Form1 = new Intro_Form1();
            Intro_Form1.Show();
            this.Hide();
        }

        private void dashboardpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void intro2btn_Click(object sender, EventArgs e)
        {
            Intro_Form2 = new Intro_Form2();
            Intro_Form2.Show();
            this.Hide();
        }

        private void intro3btn_Click(object sender, EventArgs e)
        {
            Intro_Form3 = new Intro_Form3();
            Intro_Form3.Show();
            this.Hide();
        }

        private void intro4btn_Click(object sender, EventArgs e)
        {
            Intro_Form4 = new Intro_Form4();
            Intro_Form4.Show();
            this.Hide();
        }

        private void intro5btn_Click(object sender, EventArgs e)
        {
            Intro_Form5 = new Intro_Form5();
            Intro_Form5.Show();
            this.Hide();
        }

        private void intro6btn_Click(object sender, EventArgs e)
        {
            Intro_Form6 = new Intro_Form6();
            Intro_Form6.Show();
            this.Hide();
        }

        private void intro7btn_Click(object sender, EventArgs e)
        {
            Intro_Form7 = new Intro_Form7();
            Intro_Form7.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard(userID);
            dashboard.Show();
            this.Hide();
        }
    }
}
