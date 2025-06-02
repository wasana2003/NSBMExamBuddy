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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void introbtn_Click(object sender, EventArgs e)
        {
            Introduction_to_Computer_Science introduction_To_Computer_Science = new Introduction_to_Computer_Science();
            introduction_To_Computer_Science.Show();
            this.Hide();
        }

        



        private void Dashboard_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"Welcome to the NSBM EXAM BUDDY , {CurrentUser.Name}";

        }

        private void intro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pfbtn_Click(object sender, EventArgs e)
        {
            Programming_Fundamental programming_Fundamental = new Programming_Fundamental();
            programming_Fundamental.Show();
            this.Hide();
        }

        private void mathsbtn_Click(object sender, EventArgs e)
        {
            Mathematic_for_Computing mathematic_For_Computing = new Mathematic_for_Computing();
            mathematic_For_Computing.Show();
            this.Hide();
        }

        private void dbmsbtn_Click(object sender, EventArgs e)
        {
            Database_Management_Systerm database_Management_Systerm = new Database_Management_Systerm();
            database_Management_Systerm.Show();
            this.Hide();
        }

        private void webbtn_Click(object sender, EventArgs e)
        {
            Web web = new Web();
            web.Show();
            this.Hide();
        }

        private void algobtn_Click(object sender, EventArgs e)
        {
            Alogorithms_and_Data_Structures alogorithms_And_Data_Structures = new Alogorithms_and_Data_Structures();
            alogorithms_And_Data_Structures.Show();
            this.Hide();
        }

        private void cabtn_Click(object sender, EventArgs e)
        {
            Computer_Architechture computer_Architechture = new Computer_Architechture();
            computer_Architechture.Show();
            this.Hide();
        }

        private void sadbtn_Click(object sender, EventArgs e)
        {
            System_Analysis_and_Design system_Analysis_And_Design = new System_Analysis_and_Design();
            system_Analysis_And_Design.Show();
            this.Hide();
        }

        private void oopbtn_Click(object sender, EventArgs e)
        {
            C__with_OOP c__With_OOP = new C__with_OOP();
            c__With_OOP.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
