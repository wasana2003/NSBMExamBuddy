﻿using System;
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
    public partial class PF_Form6 : Form
    {
        private int userID;

        public PF_Form6(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        public PF_Form6()
        {
        }

        private void PF_Form6_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User : {CurrentUser.Name}";

        }

        private void pfQ6btn1_Click(object sender, EventArgs e)
        {

            int submoduleID = 20;
            int userID = CurrentUser.ID;
            int moduleID = 6;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID,moduleID);
            quiz.Show();
            this.Hide();
        }

        private void pfQ6btn2_Click(object sender, EventArgs e)
        {

            int submoduleID = 21;
            int userID = CurrentUser.ID;
            int moduleID = 6;
            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID , moduleID);
            quiz.Show();
            this.Hide();
        }

        private void pfQ6btn3_Click(object sender, EventArgs e)
        {

            int submoduleID = 22;
            int userID = CurrentUser.ID;
            int moduleID = 6;

            Intro_Q_set1 quiz = new Intro_Q_set1(submoduleID, userID  ,moduleID);
            quiz.Show();
            this.Hide();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Programming_Fundamental programming_Fundamental = new Programming_Fundamental();
            programming_Fundamental.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About_Form about_Form = new About_Form();
            about_Form.Show();
            this.Hide();
        }
    }
}
