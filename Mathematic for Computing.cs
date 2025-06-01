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
    public partial class Mathematic_for_Computing : Form
    {
        public Mathematic_for_Computing()
        {
            InitializeComponent();
        }

        private void Mathematic_for_Computing_Load(object sender, EventArgs e)
        {
            displayuser.Text = $"User :, {CurrentUser.Name}";

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void maths1btn_Click(object sender, EventArgs e)
        {
            Maths_Form1 mathsForm1 = new Maths_Form1();
            mathsForm1.Show();
            this.Hide();
        }

        private void maths2btn_Click(object sender, EventArgs e)
        {
            Maths_Form2 mathsForm2 = new Maths_Form2();
            mathsForm2.Show();
            this.Hide();
        }

        private void maths3btn_Click(object sender, EventArgs e)
        {
            MATHS_Form3 mathsForm3 = new MATHS_Form3();
            mathsForm3.Show();
            this.Hide();
        }

        private void maths4btn_Click(object sender, EventArgs e)
        {
            MATHS_Form4 mathsForm4 = new MATHS_Form4();
            mathsForm4.Show();
            this.Hide();
        }

        private void maths5btn_Click(object sender, EventArgs e)
        {
            MATHS_Form5 mathsForm5 = new MATHS_Form5();
            mathsForm5.Show();
            this.Hide();
        }

        private void maths5btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
