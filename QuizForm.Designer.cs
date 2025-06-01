namespace QuizApp
{
    partial class QuizForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbB;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTimer;

        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(30, 30);
            this.lblQuestion.Size = new System.Drawing.Size(300, 20);
            this.lblQuestion.Text = "Question will appear here";

            this.rbA.Location = new System.Drawing.Point(30, 70);
            this.rbB.Location = new System.Drawing.Point(30, 100);
            this.rbC.Location = new System.Drawing.Point(30, 130);
            this.rbD.Location = new System.Drawing.Point(30, 160);

            this.btnNext.Location = new System.Drawing.Point(30, 200);
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);

            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(250, 10);
            this.lblTimer.Text = "Time Left: 20s";

            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.rbA);
            this.Controls.Add(this.rbB);
            this.Controls.Add(this.rbC);
            this.Controls.Add(this.rbD);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblTimer);
            this.ResumeLayout(false);
        }
    }
}