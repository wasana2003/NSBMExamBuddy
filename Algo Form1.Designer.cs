﻿namespace NSBMExamBuddy
{
    partial class ALGO_Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ALGO_Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayuser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.infobtn = new System.Windows.Forms.Button();
            this.signoutbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.modulebtn = new System.Windows.Forms.Button();
            this.dashboardbtn = new System.Windows.Forms.Button();
            this.algoQ1btn3 = new System.Windows.Forms.Button();
            this.algoQ1btn2 = new System.Windows.Forms.Button();
            this.algoQ1btn1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.displayuser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 84);
            this.panel1.TabIndex = 90;
            // 
            // displayuser
            // 
            this.displayuser.AutoSize = true;
            this.displayuser.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayuser.Location = new System.Drawing.Point(513, 32);
            this.displayuser.Name = "displayuser";
            this.displayuser.Size = new System.Drawing.Size(48, 23);
            this.displayuser.TabIndex = 4;
            this.displayuser.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduction to Data Science";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.infobtn);
            this.panel5.Controls.Add(this.signoutbtn);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.modulebtn);
            this.panel5.Controls.Add(this.dashboardbtn);
            this.panel5.Location = new System.Drawing.Point(15, 99);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 571);
            this.panel5.TabIndex = 91;
            // 
            // infobtn
            // 
            this.infobtn.BackColor = System.Drawing.Color.MediumPurple;
            this.infobtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infobtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.infobtn.Location = new System.Drawing.Point(0, 367);
            this.infobtn.Name = "infobtn";
            this.infobtn.Size = new System.Drawing.Size(200, 43);
            this.infobtn.TabIndex = 12;
            this.infobtn.Text = "Instructions / About\t";
            this.infobtn.UseVisualStyleBackColor = false;
            // 
            // signoutbtn
            // 
            this.signoutbtn.BackColor = System.Drawing.Color.MediumPurple;
            this.signoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signoutbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signoutbtn.Location = new System.Drawing.Point(42, 456);
            this.signoutbtn.Name = "signoutbtn";
            this.signoutbtn.Size = new System.Drawing.Size(114, 34);
            this.signoutbtn.TabIndex = 11;
            this.signoutbtn.Text = "Log Out";
            this.signoutbtn.UseVisualStyleBackColor = false;
            this.signoutbtn.Click += new System.EventHandler(this.signoutbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(0, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "My Progress\t";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // modulebtn
            // 
            this.modulebtn.BackColor = System.Drawing.Color.MediumPurple;
            this.modulebtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.modulebtn.Location = new System.Drawing.Point(0, 198);
            this.modulebtn.Name = "modulebtn";
            this.modulebtn.Size = new System.Drawing.Size(200, 43);
            this.modulebtn.TabIndex = 9;
            this.modulebtn.Text = "Modules";
            this.modulebtn.UseVisualStyleBackColor = false;
            // 
            // dashboardbtn
            // 
            this.dashboardbtn.BackColor = System.Drawing.Color.MediumPurple;
            this.dashboardbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboardbtn.Location = new System.Drawing.Point(0, 120);
            this.dashboardbtn.Name = "dashboardbtn";
            this.dashboardbtn.Size = new System.Drawing.Size(200, 43);
            this.dashboardbtn.TabIndex = 7;
            this.dashboardbtn.Text = "Dashboard";
            this.dashboardbtn.UseVisualStyleBackColor = false;
            this.dashboardbtn.Click += new System.EventHandler(this.dashboardbtn_Click);
            // 
            // algoQ1btn3
            // 
            this.algoQ1btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.algoQ1btn3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoQ1btn3.Location = new System.Drawing.Point(302, 420);
            this.algoQ1btn3.Name = "algoQ1btn3";
            this.algoQ1btn3.Size = new System.Drawing.Size(483, 43);
            this.algoQ1btn3.TabIndex = 94;
            this.algoQ1btn3.Text = "III.Data Structures-Basics and Types";
            this.algoQ1btn3.UseVisualStyleBackColor = false;
            this.algoQ1btn3.Click += new System.EventHandler(this.algoQ1btn3_Click);
            // 
            // algoQ1btn2
            // 
            this.algoQ1btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.algoQ1btn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoQ1btn2.Location = new System.Drawing.Point(302, 310);
            this.algoQ1btn2.Name = "algoQ1btn2";
            this.algoQ1btn2.Size = new System.Drawing.Size(483, 43);
            this.algoQ1btn2.TabIndex = 93;
            this.algoQ1btn2.Text = "II.Analysis of Algorithms";
            this.algoQ1btn2.UseVisualStyleBackColor = false;
            this.algoQ1btn2.Click += new System.EventHandler(this.algoQ1btn2_Click);
            // 
            // algoQ1btn1
            // 
            this.algoQ1btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.algoQ1btn1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoQ1btn1.Location = new System.Drawing.Point(302, 197);
            this.algoQ1btn1.Name = "algoQ1btn1";
            this.algoQ1btn1.Size = new System.Drawing.Size(483, 43);
            this.algoQ1btn1.TabIndex = 92;
            this.algoQ1btn1.Text = "I. Introduction to data science";
            this.algoQ1btn1.UseVisualStyleBackColor = false;
            this.algoQ1btn1.Click += new System.EventHandler(this.algoQ1btn1_Click);
            // 
            // ALGO_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(891, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.algoQ1btn3);
            this.Controls.Add(this.algoQ1btn2);
            this.Controls.Add(this.algoQ1btn1);
            this.Name = "ALGO_Form1";
            this.Text = "ALGO_Form1";
            this.Load += new System.EventHandler(this.ALGO_Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button infobtn;
        private System.Windows.Forms.Button signoutbtn;
        private System.Windows.Forms.Button modulebtn;
        private System.Windows.Forms.Button dashboardbtn;
        private System.Windows.Forms.Button algoQ1btn3;
        private System.Windows.Forms.Button algoQ1btn2;
        private System.Windows.Forms.Button algoQ1btn1;
        private System.Windows.Forms.Label displayuser;
        private System.Windows.Forms.Button button1;
    }
}