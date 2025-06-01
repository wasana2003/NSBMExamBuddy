namespace NSBMExamBuddy
{
    partial class Intro_Q_set1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.answerRadio1btn = new System.Windows.Forms.RadioButton();
            this.answerRadio4btn = new System.Windows.Forms.RadioButton();
            this.answerRadio3btn = new System.Windows.Forms.RadioButton();
            this.answerRadio2btn = new System.Windows.Forms.RadioButton();
            this.questionLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.nextbtnforQ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question";
            // 
            // answerRadio1btn
            // 
            this.answerRadio1btn.AutoSize = true;
            this.answerRadio1btn.Location = new System.Drawing.Point(124, 200);
            this.answerRadio1btn.Name = "answerRadio1btn";
            this.answerRadio1btn.Size = new System.Drawing.Size(14, 13);
            this.answerRadio1btn.TabIndex = 2;
            this.answerRadio1btn.TabStop = true;
            this.answerRadio1btn.UseVisualStyleBackColor = true;
            this.answerRadio1btn.CheckedChanged += new System.EventHandler(this.answerRadio1btn_CheckedChanged);
            // 
            // answerRadio4btn
            // 
            this.answerRadio4btn.AutoSize = true;
            this.answerRadio4btn.Location = new System.Drawing.Point(124, 397);
            this.answerRadio4btn.Name = "answerRadio4btn";
            this.answerRadio4btn.Size = new System.Drawing.Size(14, 13);
            this.answerRadio4btn.TabIndex = 3;
            this.answerRadio4btn.TabStop = true;
            this.answerRadio4btn.UseVisualStyleBackColor = true;
            // 
            // answerRadio3btn
            // 
            this.answerRadio3btn.AutoSize = true;
            this.answerRadio3btn.Location = new System.Drawing.Point(124, 334);
            this.answerRadio3btn.Name = "answerRadio3btn";
            this.answerRadio3btn.Size = new System.Drawing.Size(14, 13);
            this.answerRadio3btn.TabIndex = 4;
            this.answerRadio3btn.TabStop = true;
            this.answerRadio3btn.UseVisualStyleBackColor = true;
            // 
            // answerRadio2btn
            // 
            this.answerRadio2btn.AutoSize = true;
            this.answerRadio2btn.Location = new System.Drawing.Point(124, 266);
            this.answerRadio2btn.Name = "answerRadio2btn";
            this.answerRadio2btn.Size = new System.Drawing.Size(14, 13);
            this.answerRadio2btn.TabIndex = 5;
            this.answerRadio2btn.TabStop = true;
            this.answerRadio2btn.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(141, 87);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(0, 20);
            this.questionLabel.TabIndex = 6;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(180, 493);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(455, 23);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // nextbtnforQ
            // 
            this.nextbtnforQ.Location = new System.Drawing.Point(559, 589);
            this.nextbtnforQ.Name = "nextbtnforQ";
            this.nextbtnforQ.Size = new System.Drawing.Size(75, 23);
            this.nextbtnforQ.TabIndex = 8;
            this.nextbtnforQ.Text = "Next";
            this.nextbtnforQ.UseVisualStyleBackColor = true;
            this.nextbtnforQ.Click += new System.EventHandler(this.nextbtnforQ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "*";
            // 
            // Intro_Q_set1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 704);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nextbtnforQ);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.answerRadio2btn);
            this.Controls.Add(this.answerRadio3btn);
            this.Controls.Add(this.answerRadio4btn);
            this.Controls.Add(this.answerRadio1btn);
            this.Controls.Add(this.label1);
            this.Name = "Intro_Q_set1";
            this.Text = "Intro_Q_set 1";
            this.Load += new System.EventHandler(this.Intro_Q_set1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton answerRadio1btn;
        private System.Windows.Forms.RadioButton answerRadio4btn;
        private System.Windows.Forms.RadioButton answerRadio3btn;
        private System.Windows.Forms.RadioButton answerRadio2btn;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button nextbtnforQ;
        private System.Windows.Forms.Label label2;
    }
}