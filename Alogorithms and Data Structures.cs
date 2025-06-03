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
    public partial class Alogorithms_and_Data_Structures : Form
    {
        private int userID;

        public Alogorithms_and_Data_Structures()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void algo1btn_Click(object sender, EventArgs e)
        {
            ALGO_Form1 aLGO_Form1 = new ALGO_Form1();
            aLGO_Form1.Show();
            this.Hide();
        }

        private void algo2btn_Click(object sender, EventArgs e)
        {
            Algo_Form2 aLGO_Form2 = new Algo_Form2();
            aLGO_Form2.Show();
            this.Hide();
        }

        private void algo3btn_Click(object sender, EventArgs e)
        {
            Algo_Form3 aLGO_Form3 = new Algo_Form3();
            aLGO_Form3.Show();
            this.Hide();
        }

        private void algo4btn_Click(object sender, EventArgs e)
        {
            Algo_Form4 aLGO_Form4 = new Algo_Form4();
            aLGO_Form4.Show();
            this.Hide();
        }

        private void algo5btn_Click(object sender, EventArgs e)
        {
            Algo_Form5 aLGO_Form5 = new Algo_Form5();
            aLGO_Form5.Show();
            this.Hide();
        }

        private void algo6btn_Click(object sender, EventArgs e)
        {
            Algo_Form6 aLGO_Form6 = new Algo_Form6();
            aLGO_Form6.Show();
            this.Hide();
        }

        private void Alogorithms_and_Data_Structures_Load(object sender, EventArgs e)
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
