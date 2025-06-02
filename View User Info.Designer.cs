namespace NSBMExamBuddy
{
    partial class View_User_Info
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
            this.displayUname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.enteruserid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewinfo = new System.Windows.Forms.DataGridView();
            this.displayEmail = new System.Windows.Forms.Label();
            this.displayStream = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // displayUname
            // 
            this.displayUname.AutoSize = true;
            this.displayUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayUname.Location = new System.Drawing.Point(23, 125);
            this.displayUname.Name = "displayUname";
            this.displayUname.Size = new System.Drawing.Size(93, 18);
            this.displayUname.TabIndex = 8;
            this.displayUname.Text = "User Name";
            this.displayUname.Click += new System.EventHandler(this.displayusername_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(316, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enteruserid
            // 
            this.enteruserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enteruserid.Location = new System.Drawing.Point(194, 57);
            this.enteruserid.Name = "enteruserid";
            this.enteruserid.Size = new System.Drawing.Size(100, 24);
            this.enteruserid.TabIndex = 6;
            this.enteruserid.TextChanged += new System.EventHandler(this.enteruserid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter the User ID Here :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewinfo
            // 
            this.dataGridViewinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewinfo.Location = new System.Drawing.Point(438, 33);
            this.dataGridViewinfo.Name = "dataGridViewinfo";
            this.dataGridViewinfo.Size = new System.Drawing.Size(135, 260);
            this.dataGridViewinfo.TabIndex = 9;
            this.dataGridViewinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // displayEmail
            // 
            this.displayEmail.AutoSize = true;
            this.displayEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEmail.Location = new System.Drawing.Point(23, 184);
            this.displayEmail.Name = "displayEmail";
            this.displayEmail.Size = new System.Drawing.Size(93, 18);
            this.displayEmail.TabIndex = 10;
            this.displayEmail.Text = "User Name";
            this.displayEmail.Click += new System.EventHandler(this.label2_Click);
            // 
            // displayStream
            // 
            this.displayStream.AutoSize = true;
            this.displayStream.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayStream.Location = new System.Drawing.Point(23, 236);
            this.displayStream.Name = "displayStream";
            this.displayStream.Size = new System.Drawing.Size(93, 18);
            this.displayStream.TabIndex = 11;
            this.displayStream.Text = "User Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(74)))), ((int)(((byte)(234)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(253, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 39);
            this.button2.TabIndex = 12;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // View_User_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(611, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.displayStream);
            this.Controls.Add(this.displayEmail);
            this.Controls.Add(this.dataGridViewinfo);
            this.Controls.Add(this.displayUname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enteruserid);
            this.Controls.Add(this.label1);
            this.Name = "View_User_Info";
            this.Text = "View_User_Info";
            this.Load += new System.EventHandler(this.View_User_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label displayUname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox enteruserid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewinfo;
        private System.Windows.Forms.Label displayEmail;
        private System.Windows.Forms.Label displayStream;
        private System.Windows.Forms.Button button2;
    }
}