﻿namespace NSBMExamBuddy
{
    partial class View_User_Progress
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.scoreIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submoduleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nSBMExamBuddyDataSet = new NSBMExamBuddy.NSBMExamBuddyDataSet();
            this.userScoresTableAdapter = new NSBMExamBuddy.NSBMExamBuddyDataSetTableAdapters.UserScoresTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.enteruserid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.displayusername = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userScoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSBMExamBuddyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scoreIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.submoduleIDDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.dateTakenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userScoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(125, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // scoreIDDataGridViewTextBoxColumn
            // 
            this.scoreIDDataGridViewTextBoxColumn.DataPropertyName = "ScoreID";
            this.scoreIDDataGridViewTextBoxColumn.HeaderText = "ScoreID";
            this.scoreIDDataGridViewTextBoxColumn.Name = "scoreIDDataGridViewTextBoxColumn";
            this.scoreIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // submoduleIDDataGridViewTextBoxColumn
            // 
            this.submoduleIDDataGridViewTextBoxColumn.DataPropertyName = "SubmoduleID";
            this.submoduleIDDataGridViewTextBoxColumn.HeaderText = "SubmoduleID";
            this.submoduleIDDataGridViewTextBoxColumn.Name = "submoduleIDDataGridViewTextBoxColumn";
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            // 
            // dateTakenDataGridViewTextBoxColumn
            // 
            this.dateTakenDataGridViewTextBoxColumn.DataPropertyName = "DateTaken";
            this.dateTakenDataGridViewTextBoxColumn.HeaderText = "DateTaken";
            this.dateTakenDataGridViewTextBoxColumn.Name = "dateTakenDataGridViewTextBoxColumn";
            // 
            // userScoresBindingSource
            // 
            this.userScoresBindingSource.DataMember = "UserScores";
            this.userScoresBindingSource.DataSource = this.nSBMExamBuddyDataSet;
            // 
            // nSBMExamBuddyDataSet
            // 
            this.nSBMExamBuddyDataSet.DataSetName = "NSBMExamBuddyDataSet";
            this.nSBMExamBuddyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userScoresTableAdapter
            // 
            this.userScoresTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the User ID :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // enteruserid
            // 
            this.enteruserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enteruserid.Location = new System.Drawing.Point(326, 361);
            this.enteruserid.Name = "enteruserid";
            this.enteruserid.Size = new System.Drawing.Size(100, 26);
            this.enteruserid.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(74)))), ((int)(((byte)(234)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(559, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayusername
            // 
            this.displayusername.AutoSize = true;
            this.displayusername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayusername.Location = new System.Drawing.Point(322, 451);
            this.displayusername.Name = "displayusername";
            this.displayusername.Size = new System.Drawing.Size(145, 18);
            this.displayusername.TabIndex = 4;
            this.displayusername.Text = "Enter the User ID";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(74)))), ((int)(((byte)(234)))));
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.back.Location = new System.Drawing.Point(559, 402);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(109, 39);
            this.back.TabIndex = 13;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // View_User_Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 676);
            this.Controls.Add(this.back);
            this.Controls.Add(this.displayusername);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enteruserid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View_User_Progress";
            this.Text = "View_User_Progress";
            this.Load += new System.EventHandler(this.View_User_Progress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userScoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSBMExamBuddyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private NSBMExamBuddyDataSet nSBMExamBuddyDataSet;
        private System.Windows.Forms.BindingSource userScoresBindingSource;
        private NSBMExamBuddyDataSetTableAdapters.UserScoresTableAdapter userScoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn submoduleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enteruserid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label displayusername;
        private System.Windows.Forms.Button back;
    }
}