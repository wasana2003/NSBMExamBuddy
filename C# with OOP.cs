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
    public partial class C__with_OOP : Form
    {
        public C__with_OOP()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void csharpe1btn_Click(object sender, EventArgs e)
        {
            CSharpe_Form1 cSharpeForm1 = new CSharpe_Form1();
            cSharpeForm1.Show();
            this.Hide();
        }

        private void csharpe2btn_Click(object sender, EventArgs e)
        {
            CSharpe_Form2 cSharpeForm2 = new CSharpe_Form2();
            cSharpeForm2.Show();
            this.Hide();
        }

        private void csharpe3btn_Click(object sender, EventArgs e)
        {
            CSharpe_Form3 cSharpeForm3 = new CSharpe_Form3();
            cSharpeForm3.Show();
            this.Hide();
        }

        private void csharpe4btn_Click(object sender, EventArgs e)
        {
            CSharpe_Form4 cSharpeForm4 = new CSharpe_Form4();
            cSharpeForm4.Show();
            this.Hide();
        }

        private void csharpe5btn_Click(object sender, EventArgs e)
        {
            CSharpe_Form5 cSharpeForm5 = new CSharpe_Form5();
            cSharpeForm5.Show();
            this.Hide();
        }

        private void csharpe6btn_Click(object sender, EventArgs e)
        {
            CSharpe_Form6 cSharpeForm6 = new CSharpe_Form6();
            cSharpeForm6.Show();
            this.Hide();
        }

        private void csharpe7btn_Click(object sender, EventArgs e)
        {
            CSharpe_Form7 cSharpeForm7 = new CSharpe_Form7();
            cSharpeForm7.Show();
            this.Hide();
        }

        private void C__with_OOP_Load(object sender, EventArgs e)
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
