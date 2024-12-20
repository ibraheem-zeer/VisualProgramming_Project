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
            Courses = new TabPage();
            TeacherCoursesList = new ListView();
            Exams = new TabPage();
            seeResult = new Button();
            CompleteExam = new Button();
            panel2 = new Panel();
            label3 = new Label();
            examsDataGridView = new DataGridView();
            panel1 = new Panel();
            yourCoursesDataGridView = new DataGridView();
            label1 = new Label();
            tabControl1.SuspendLayout();
            Courses.SuspendLayout();
            Exams.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)examsDataGridView).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yourCoursesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Courses);
            tabControl1.Controls.Add(Exams);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1180, 755);
            tabControl1.TabIndex = 0;
            // 
            // Courses
            // 
            Courses.Controls.Add(TeacherCoursesList);
            Courses.Location = new Point(4, 34);
            Courses.Name = "Courses";
            Courses.Padding = new Padding(3);
            Courses.Size = new Size(1172, 717);
            Courses.TabIndex = 0;
            Courses.Text = "Courses";
            Courses.UseVisualStyleBackColor = true;
            // 
            // TeacherCoursesList
            // 
            TeacherCoursesList.Location = new Point(159, 69);
            TeacherCoursesList.Name = "TeacherCoursesList";
            TeacherCoursesList.Size = new Size(474, 275);
            TeacherCoursesList.TabIndex = 1;
            TeacherCoursesList.UseCompatibleStateImageBehavior = false;
            // 
            // Exams
            // 
            Exams.Controls.Add(seeResult);
            Exams.Controls.Add(CompleteExam);
            Exams.Controls.Add(panel2);
            Exams.Controls.Add(panel1);
            Exams.Location = new Point(4, 34);
            Exams.Name = "Exams";
            Exams.Padding = new Padding(3);
            Exams.Size = new Size(1172, 717);
            Exams.TabIndex = 1;
            Exams.Text = "Exams";
            Exams.UseVisualStyleBackColor = true;
            // 
            // seeResult
            // 
            seeResult.Location = new Point(1008, 405);
            seeResult.Margin = new Padding(4, 5, 4, 5);
            seeResult.Name = "seeResult";
            seeResult.Size = new Size(107, 65);
            seeResult.TabIndex = 11;
            seeResult.Text = "See Result";
            seeResult.UseVisualStyleBackColor = true;
            // 
            // CompleteExam
            // 
            CompleteExam.Location = new Point(285, 405);
            CompleteExam.Margin = new Padding(4, 5, 4, 5);
            CompleteExam.Name = "CompleteExam";
            CompleteExam.Size = new Size(155, 65);
            CompleteExam.TabIndex = 10;
            CompleteExam.Text = "Complete Exam";
            CompleteExam.UseVisualStyleBackColor = true;
            CompleteExam.Click += CompleteExam_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(examsDataGridView);
            panel2.Location = new Point(279, 8);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(836, 365);
            panel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(4, 15);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(196, 38);
            label3.TabIndex = 3;
            label3.Text = "Exams Course ";
            // 
            // examsDataGridView
            // 
            examsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            examsDataGridView.Location = new Point(4, 62);
            examsDataGridView.Margin = new Padding(4, 5, 4, 5);
            examsDataGridView.Name = "examsDataGridView";
            examsDataGridView.RowHeadersWidth = 62;
            examsDataGridView.Size = new Size(826, 297);
            examsDataGridView.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(yourCoursesDataGridView);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(9, 8);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 679);
            panel1.TabIndex = 8;
            // 
            // yourCoursesDataGridView
            // 
            yourCoursesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            yourCoursesDataGridView.Location = new Point(4, 62);
            yourCoursesDataGridView.Margin = new Padding(4, 5, 4, 5);
            yourCoursesDataGridView.Name = "yourCoursesDataGridView";
            yourCoursesDataGridView.RowHeadersWidth = 62;
            yourCoursesDataGridView.Size = new Size(250, 610);
            yourCoursesDataGridView.TabIndex = 4;
            yourCoursesDataGridView.CellClick += yourCoursesDataGridView_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(17, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(178, 38);
            label1.TabIndex = 0;
            label1.Text = "Your Courses";
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 755);
            Controls.Add(tabControl1);
            Name = "TeacherForm";
            Text = "TeacherForm";
            Load += TeacherForm_Load;
            tabControl1.ResumeLayout(false);
            Courses.ResumeLayout(false);
            Exams.ResumeLayout(false);
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
        private TabPage Courses;
        private ListView TeacherCoursesList;
        private TabPage Exams;
        private Button seeResult;
        private Button CompleteExam;
        private Panel panel2;
        private Label label3;
        private DataGridView examsDataGridView;
        private Panel panel1;
        private DataGridView yourCoursesDataGridView;
        private Label label1;
    }
}