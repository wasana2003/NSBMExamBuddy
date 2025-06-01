namespace NSBMExamBuddy
{
    partial class Admin_Dashboard
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
            this.userProgress = new System.Windows.Forms.Button();
            this.userdetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // userProgress
            // 
            this.userProgress.Location = new System.Drawing.Point(57, 128);
            this.userProgress.Name = "userProgress";
            this.userProgress.Size = new System.Drawing.Size(197, 42);
            this.userProgress.TabIndex = 1;
            this.userProgress.Text = "User Progress";
            this.userProgress.UseVisualStyleBackColor = true;
            this.userProgress.Click += new System.EventHandler(this.userProgress_Click);
            // 
            // userdetails
            // 
            this.userdetails.Location = new System.Drawing.Point(57, 207);
            this.userdetails.Name = "userdetails";
            this.userdetails.Size = new System.Drawing.Size(197, 42);
            this.userdetails.TabIndex = 2;
            this.userdetails.Text = "User Info";
            this.userdetails.UseVisualStyleBackColor = true;
            this.userdetails.Click += new System.EventHandler(this.userdetails_Click);
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 527);
            this.Controls.Add(this.userdetails);
            this.Controls.Add(this.userProgress);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Dashboard";
            this.Text = "Admin_Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button userProgress;
        private System.Windows.Forms.Button userdetails;
    }
}