﻿namespace VisualProgramming_Project
{
    partial class StudentForm
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
            tabControl1 = new TabControl();
            Profile = new TabPage();
            panel4 = new Panel();
            startExam = new Button();
            seeResult = new Button();
            panel2 = new Panel();
            label3 = new Label();
            examsDataGridView = new DataGridView();
            panel1 = new Panel();
            yourCoursesDataGridView = new DataGridView();
            label1 = new Label();
            tabPage2 = new TabPage();
            CouresKey = new TextBox();
            logout = new Button();
            panel3 = new Panel();
            rollCourse = new Button();
            unRoll = new Button();
            label2 = new Label();
            coursesDataGridView = new DataGridView();
            label4 = new Label();
            tabControl1.SuspendLayout();
            Profile.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)examsDataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yourCoursesDataGridView).BeginInit();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coursesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Profile);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // Profile
            // 
            Profile.BorderStyle = BorderStyle.Fixed3D;
            Profile.Controls.Add(panel4);
            Profile.Controls.Add(panel2);
            Profile.Controls.Add(panel1);
            Profile.Location = new Point(4, 24);
            Profile.Name = "Profile";
            Profile.Padding = new Padding(3);
            Profile.Size = new Size(792, 422);
            Profile.TabIndex = 0;
            Profile.Text = "Dashboard";
            Profile.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(startExam);
            panel4.Controls.Add(seeResult);
            panel4.Location = new Point(342, 276);
            panel4.Name = "panel4";
            panel4.Size = new Size(261, 86);
            panel4.TabIndex = 8;
            // 
            // startExam
            // 
            startExam.Location = new Point(8, 9);
            startExam.Name = "startExam";
            startExam.Size = new Size(116, 68);
            startExam.TabIndex = 6;
            startExam.Text = "Start Exam";
            startExam.UseVisualStyleBackColor = true;
            startExam.Click += startExam_Click;
            // 
            // seeResult
            // 
            seeResult.Location = new Point(137, 9);
            seeResult.Name = "seeResult";
            seeResult.Size = new Size(116, 68);
            seeResult.TabIndex = 7;
            seeResult.Text = "See Result";
            seeResult.UseVisualStyleBackColor = true;
            seeResult.Click += seeResult_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(logout);
            panel2.Controls.Add(examsDataGridView);
            panel2.Location = new Point(197, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 220);
            panel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 3;
            label3.Text = "Exams Course ";
            // 
            // examsDataGridView
            // 
            examsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            examsDataGridView.Location = new Point(3, 37);
            examsDataGridView.Name = "examsDataGridView";
            examsDataGridView.RowHeadersWidth = 62;
            examsDataGridView.Size = new Size(578, 178);
            examsDataGridView.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(yourCoursesDataGridView);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(8, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 408);
            panel1.TabIndex = 4;
            // 
            // yourCoursesDataGridView
            // 
            yourCoursesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            yourCoursesDataGridView.Location = new Point(3, 37);
            yourCoursesDataGridView.Name = "yourCoursesDataGridView";
            yourCoursesDataGridView.RowHeadersWidth = 62;
            yourCoursesDataGridView.Size = new Size(175, 366);
            yourCoursesDataGridView.TabIndex = 4;
            yourCoursesDataGridView.CellClick += yourCoursesDataGridView_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 0;
            label1.Text = "Your Courses";
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(CouresKey);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(coursesDataGridView);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Roll Courses";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // CouresKey
            // 
            CouresKey.Location = new Point(114, 253);
            CouresKey.Margin = new Padding(2);
            CouresKey.Name = "CouresKey";
            CouresKey.Size = new Size(106, 23);
            CouresKey.TabIndex = 25;
            // 
            // logout
            // 
            logout.Location = new Point(506, 3);
            logout.Name = "logout";
            logout.Size = new Size(75, 30);
            logout.TabIndex = 24;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(rollCourse);
            panel3.Controls.Add(unRoll);
            panel3.Location = new Point(293, 253);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 4;
            // 
            // rollCourse
            // 
            rollCourse.Location = new Point(24, 25);
            rollCourse.Name = "rollCourse";
            rollCourse.Size = new Size(75, 50);
            rollCourse.TabIndex = 2;
            rollCourse.Text = "Roll Course";
            rollCourse.UseVisualStyleBackColor = true;
            rollCourse.Click += rollCourse_Click;
            // 
            // unRoll
            // 
            unRoll.Location = new Point(105, 25);
            unRoll.Name = "unRoll";
            unRoll.Size = new Size(75, 50);
            unRoll.TabIndex = 3;
            unRoll.Text = "Un Roll";
            unRoll.UseVisualStyleBackColor = true;
            unRoll.Click += unRoll_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(6, 34);
            label2.Name = "label2";
            label2.Size = new Size(231, 25);
            label2.TabIndex = 1;
            label2.Text = "Courses In Your University";
            // 
            // coursesDataGridView
            // 
            coursesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursesDataGridView.Location = new Point(6, 71);
            coursesDataGridView.Name = "coursesDataGridView";
            coursesDataGridView.RowHeadersWidth = 62;
            coursesDataGridView.Size = new Size(780, 150);
            coursesDataGridView.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 256);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 26;
            label4.Text = "Kay Course";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            tabControl1.ResumeLayout(false);
            Profile.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)examsDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yourCoursesDataGridView).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)coursesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Profile;
        private TabPage tabPage2;
        private Label label1;
        private Button unRoll;
        private Button rollCourse;
        private Label label2;
        private DataGridView coursesDataGridView;
        private Button seeResult;
        private Button startExam;
        private Panel panel2;
        private Label label3;
        private DataGridView examsDataGridView;
        private Panel panel1;
        private Panel panel3;
        private DataGridView yourCoursesDataGridView;
        private Button logout;
        private TextBox CouresKey;
        private Panel panel4;
        private Label label4;
    }
}