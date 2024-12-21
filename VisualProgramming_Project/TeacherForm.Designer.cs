namespace VisualProgramming_Project
{
    partial class TeacherForm
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
            Exams = new TabPage();
            panel3 = new Panel();
            CompleteExam = new Button();
            seeResult = new Button();
            panel2 = new Panel();
            logout = new Button();
            label3 = new Label();
            examsDataGridView = new DataGridView();
            panel1 = new Panel();
            yourCoursesDataGridView = new DataGridView();
            label1 = new Label();
            tabControl1.SuspendLayout();
            Exams.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)examsDataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yourCoursesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Exams);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 453);
            tabControl1.TabIndex = 0;
            // 
            // Exams
            // 
            Exams.BorderStyle = BorderStyle.Fixed3D;
            Exams.Controls.Add(panel3);
            Exams.Controls.Add(panel2);
            Exams.Controls.Add(panel1);
            Exams.Location = new Point(4, 24);
            Exams.Margin = new Padding(2);
            Exams.Name = "Exams";
            Exams.Padding = new Padding(2);
            Exams.Size = new Size(786, 425);
            Exams.TabIndex = 1;
            Exams.Text = "Exams";
            Exams.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(CompleteExam);
            panel3.Controls.Add(seeResult);
            panel3.Location = new Point(370, 276);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 86);
            panel3.TabIndex = 12;
            // 
            // CompleteExam
            // 
            CompleteExam.Location = new Point(3, 3);
            CompleteExam.Name = "CompleteExam";
            CompleteExam.Size = new Size(108, 78);
            CompleteExam.TabIndex = 10;
            CompleteExam.Text = "Complete Exam";
            CompleteExam.UseVisualStyleBackColor = true;
            CompleteExam.Click += CompleteExam_Click;
            // 
            // seeResult
            // 
            seeResult.Location = new Point(117, 3);
            seeResult.Name = "seeResult";
            seeResult.Size = new Size(111, 78);
            seeResult.TabIndex = 11;
            seeResult.Text = "See Result";
            seeResult.UseVisualStyleBackColor = true;
            seeResult.Click += seeResult_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(logout);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(examsDataGridView);
            panel2.Location = new Point(195, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(586, 220);
            panel2.TabIndex = 9;
            // 
            // logout
            // 
            logout.Location = new Point(513, 9);
            logout.Name = "logout";
            logout.Size = new Size(68, 24);
            logout.TabIndex = 25;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
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
            panel1.Location = new Point(6, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 408);
            panel1.TabIndex = 8;
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
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 453);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            Name = "TeacherForm";
            Text = "TeacherForm";
            Load += TeacherForm_Load;
            tabControl1.ResumeLayout(false);
            Exams.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)examsDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yourCoursesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Exams;
        private Button seeResult;
        private Button CompleteExam;
        private Panel panel2;
        private Label label3;
        private DataGridView examsDataGridView;
        private Panel panel1;
        private DataGridView yourCoursesDataGridView;
        private Label label1;
        private Button logout;
        private Panel panel3;
    }
}