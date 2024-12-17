namespace VisualProgramming_Project
{
    partial class AdminDashboard
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
            tabPage2 = new TabPage();
            coursesTeacherListView = new ListView();
            button1 = new Button();
            updateTeacher = new Button();
            addTeacher = new Button();
            removeTeacher = new Button();
            teacherPassword = new TextBox();
            teacherEmail = new TextBox();
            teacherName = new TextBox();
            teacherCollage = new TextBox();
            teacherLabel = new Label();
            teachersDataGridView = new DataGridView();
            tabPage1 = new TabPage();
            removeStudent = new Button();
            studentSpecialization = new TextBox();
            studentPassword = new TextBox();
            studentEmail = new TextBox();
            studentName = new TextBox();
            updateStudent = new Button();
            addStudent = new Button();
            studentLabel = new Label();
            studentsDataGridView = new DataGridView();
            tabPage4 = new TabPage();
            changeTeacherOfCourse = new Button();
            courseLevel = new TextBox();
            courseDescription = new TextBox();
            courseName = new TextBox();
            updateCourse = new Button();
            addCourse = new Button();
            removeCourse = new Button();
            coursesLabel = new Label();
            coursesDataGridView = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teachersDataGridView).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coursesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(882, 617);
            tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(coursesTeacherListView);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(updateTeacher);
            tabPage2.Controls.Add(addTeacher);
            tabPage2.Controls.Add(removeTeacher);
            tabPage2.Controls.Add(teacherPassword);
            tabPage2.Controls.Add(teacherEmail);
            tabPage2.Controls.Add(teacherName);
            tabPage2.Controls.Add(teacherCollage);
            tabPage2.Controls.Add(teacherLabel);
            tabPage2.Controls.Add(teachersDataGridView);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(874, 589);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Teacher";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // coursesTeacherListView
            // 
            coursesTeacherListView.Anchor = AnchorStyles.Bottom;
            coursesTeacherListView.Font = new Font("Segoe UI", 14F);
            coursesTeacherListView.Location = new Point(622, 296);
            coursesTeacherListView.Name = "coursesTeacherListView";
            coursesTeacherListView.Size = new Size(142, 222);
            coursesTeacherListView.TabIndex = 13;
            coursesTeacherListView.UseCompatibleStateImageBehavior = false;
            coursesTeacherListView.View = View.Tile;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(622, 256);
            button1.Name = "button1";
            button1.Size = new Size(142, 34);
            button1.TabIndex = 12;
            button1.Text = "Show Courses";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // updateTeacher
            // 
            updateTeacher.Location = new Point(256, 305);
            updateTeacher.Name = "updateTeacher";
            updateTeacher.Size = new Size(75, 121);
            updateTeacher.TabIndex = 11;
            updateTeacher.Text = "Update";
            updateTeacher.UseVisualStyleBackColor = true;
            updateTeacher.Click += updateTeacher_Click;
            // 
            // addTeacher
            // 
            addTeacher.Location = new Point(166, 305);
            addTeacher.Name = "addTeacher";
            addTeacher.Size = new Size(75, 121);
            addTeacher.TabIndex = 10;
            addTeacher.Text = "Add";
            addTeacher.UseVisualStyleBackColor = true;
            addTeacher.Click += addTeacher_Click_1;
            // 
            // removeTeacher
            // 
            removeTeacher.Location = new Point(40, 211);
            removeTeacher.Name = "removeTeacher";
            removeTeacher.Size = new Size(223, 23);
            removeTeacher.TabIndex = 9;
            removeTeacher.Text = "Remove";
            removeTeacher.UseVisualStyleBackColor = true;
            removeTeacher.Click += removeTeacher_Click;
            // 
            // teacherPassword
            // 
            teacherPassword.Font = new Font("Segoe UI", 14F);
            teacherPassword.Location = new Point(40, 372);
            teacherPassword.Name = "teacherPassword";
            teacherPassword.Size = new Size(100, 32);
            teacherPassword.TabIndex = 8;
            teacherPassword.UseSystemPasswordChar = true;
            // 
            // teacherEmail
            // 
            teacherEmail.Font = new Font("Segoe UI", 14F);
            teacherEmail.Location = new Point(40, 334);
            teacherEmail.Name = "teacherEmail";
            teacherEmail.Size = new Size(100, 32);
            teacherEmail.TabIndex = 7;
            // 
            // teacherName
            // 
            teacherName.Font = new Font("Segoe UI", 14F);
            teacherName.Location = new Point(40, 296);
            teacherName.Name = "teacherName";
            teacherName.Size = new Size(100, 32);
            teacherName.TabIndex = 6;
            // 
            // teacherCollage
            // 
            teacherCollage.Font = new Font("Segoe UI", 14F);
            teacherCollage.Location = new Point(40, 410);
            teacherCollage.Name = "teacherCollage";
            teacherCollage.Size = new Size(100, 32);
            teacherCollage.TabIndex = 5;
            // 
            // teacherLabel
            // 
            teacherLabel.AutoSize = true;
            teacherLabel.Font = new Font("Segoe UI", 16F);
            teacherLabel.Location = new Point(6, 22);
            teacherLabel.Name = "teacherLabel";
            teacherLabel.Size = new Size(97, 30);
            teacherLabel.TabIndex = 3;
            teacherLabel.Text = "Teachers";
            // 
            // teachersDataGridView
            // 
            teachersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teachersDataGridView.Location = new Point(6, 55);
            teachersDataGridView.Name = "teachersDataGridView";
            teachersDataGridView.Size = new Size(856, 150);
            teachersDataGridView.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(removeStudent);
            tabPage1.Controls.Add(studentSpecialization);
            tabPage1.Controls.Add(studentPassword);
            tabPage1.Controls.Add(studentEmail);
            tabPage1.Controls.Add(studentName);
            tabPage1.Controls.Add(updateStudent);
            tabPage1.Controls.Add(addStudent);
            tabPage1.Controls.Add(studentLabel);
            tabPage1.Controls.Add(studentsDataGridView);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(874, 589);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Student";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // removeStudent
            // 
            removeStudent.Location = new Point(371, 210);
            removeStudent.Name = "removeStudent";
            removeStudent.Size = new Size(75, 23);
            removeStudent.TabIndex = 9;
            removeStudent.Text = "Remove";
            removeStudent.UseVisualStyleBackColor = true;
            removeStudent.Click += removeStudent_Click;
            // 
            // studentSpecialization
            // 
            studentSpecialization.Location = new Point(96, 372);
            studentSpecialization.Name = "studentSpecialization";
            studentSpecialization.Size = new Size(100, 23);
            studentSpecialization.TabIndex = 8;
            // 
            // studentPassword
            // 
            studentPassword.Location = new Point(96, 343);
            studentPassword.Name = "studentPassword";
            studentPassword.Size = new Size(100, 23);
            studentPassword.TabIndex = 7;
            // 
            // studentEmail
            // 
            studentEmail.Location = new Point(96, 314);
            studentEmail.Name = "studentEmail";
            studentEmail.Size = new Size(100, 23);
            studentEmail.TabIndex = 6;
            // 
            // studentName
            // 
            studentName.Location = new Point(96, 285);
            studentName.Name = "studentName";
            studentName.Size = new Size(100, 23);
            studentName.TabIndex = 5;
            // 
            // updateStudent
            // 
            updateStudent.Location = new Point(323, 281);
            updateStudent.Name = "updateStudent";
            updateStudent.Size = new Size(75, 123);
            updateStudent.TabIndex = 4;
            updateStudent.Text = "Update";
            updateStudent.UseVisualStyleBackColor = true;
            updateStudent.Click += updateStudent_Click;
            // 
            // addStudent
            // 
            addStudent.Location = new Point(225, 281);
            addStudent.Name = "addStudent";
            addStudent.Size = new Size(75, 123);
            addStudent.TabIndex = 3;
            addStudent.Text = "Add";
            addStudent.UseVisualStyleBackColor = true;
            addStudent.Click += addStudent_Click;
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.Font = new Font("Segoe UI", 16F);
            studentLabel.Location = new Point(6, 22);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new Size(96, 30);
            studentLabel.TabIndex = 1;
            studentLabel.Text = "Students";
            // 
            // studentsDataGridView
            // 
            studentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsDataGridView.Location = new Point(6, 55);
            studentsDataGridView.Name = "studentsDataGridView";
            studentsDataGridView.Size = new Size(856, 150);
            studentsDataGridView.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(changeTeacherOfCourse);
            tabPage4.Controls.Add(courseLevel);
            tabPage4.Controls.Add(courseDescription);
            tabPage4.Controls.Add(courseName);
            tabPage4.Controls.Add(updateCourse);
            tabPage4.Controls.Add(addCourse);
            tabPage4.Controls.Add(removeCourse);
            tabPage4.Controls.Add(coursesLabel);
            tabPage4.Controls.Add(coursesDataGridView);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(874, 589);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Course";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // changeTeacherOfCourse
            // 
            changeTeacherOfCourse.Location = new Point(409, 275);
            changeTeacherOfCourse.Name = "changeTeacherOfCourse";
            changeTeacherOfCourse.Size = new Size(75, 123);
            changeTeacherOfCourse.TabIndex = 10;
            changeTeacherOfCourse.Text = "Change Teacher";
            changeTeacherOfCourse.UseVisualStyleBackColor = true;
            changeTeacherOfCourse.Click += changeTeacherOfCourse_Click;
            // 
            // courseLevel
            // 
            courseLevel.Location = new Point(90, 351);
            courseLevel.Name = "courseLevel";
            courseLevel.Size = new Size(100, 23);
            courseLevel.TabIndex = 9;
            // 
            // courseDescription
            // 
            courseDescription.Location = new Point(90, 322);
            courseDescription.Name = "courseDescription";
            courseDescription.Size = new Size(100, 23);
            courseDescription.TabIndex = 8;
            // 
            // courseName
            // 
            courseName.Location = new Point(90, 293);
            courseName.Name = "courseName";
            courseName.Size = new Size(100, 23);
            courseName.TabIndex = 7;
            // 
            // updateCourse
            // 
            updateCourse.Location = new Point(310, 275);
            updateCourse.Name = "updateCourse";
            updateCourse.Size = new Size(75, 123);
            updateCourse.TabIndex = 6;
            updateCourse.Text = "Update";
            updateCourse.UseVisualStyleBackColor = true;
            updateCourse.Click += updateCourse_Click;
            // 
            // addCourse
            // 
            addCourse.Location = new Point(215, 275);
            addCourse.Name = "addCourse";
            addCourse.Size = new Size(75, 123);
            addCourse.TabIndex = 5;
            addCourse.Text = "Add";
            addCourse.UseVisualStyleBackColor = true;
            addCourse.Click += addCourse_Click;
            // 
            // removeCourse
            // 
            removeCourse.Location = new Point(377, 208);
            removeCourse.Name = "removeCourse";
            removeCourse.Size = new Size(75, 23);
            removeCourse.TabIndex = 4;
            removeCourse.Text = "Remove";
            removeCourse.UseVisualStyleBackColor = true;
            removeCourse.Click += removeCourse_Click;
            // 
            // coursesLabel
            // 
            coursesLabel.AutoSize = true;
            coursesLabel.Font = new Font("Segoe UI", 16F);
            coursesLabel.Location = new Point(6, 22);
            coursesLabel.Name = "coursesLabel";
            coursesLabel.Size = new Size(90, 30);
            coursesLabel.TabIndex = 3;
            coursesLabel.Text = "Courses";
            // 
            // coursesDataGridView
            // 
            coursesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursesDataGridView.Location = new Point(6, 55);
            coursesDataGridView.Name = "coursesDataGridView";
            coursesDataGridView.Size = new Size(856, 150);
            coursesDataGridView.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 617);
            Controls.Add(tabControl1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teachersDataGridView).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coursesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private Label studentLabel;
        private DataGridView studentsDataGridView;
        private Label teacherLabel;
        private DataGridView teachersDataGridView;
        private Label coursesLabel;
        private DataGridView coursesDataGridView;
        private TextBox teacherCollage;
        private TextBox teacherPassword;
        private TextBox teacherEmail;
        private TextBox teacherName;
        private Button removeTeacher;
        private Button updateTeacher;
        private Button addTeacher;
        private TextBox textBox5;
        private TextBox studentSpecialization;
        private TextBox studentPassword;
        private TextBox studentEmail;
        private TextBox studentName;
        private Button updateStudent;
        private Button addStudent;
        private Button removeStudent;
        private Button removeCourse;
        private Button updateCourse;
        private Button addCourse;
        private TextBox courseLevel;
        private TextBox courseDescription;
        private TextBox courseName;
        private Button changeTeacherOfCourse;
        private Button button1;
        private ListView coursesTeacherListView;
        private ColumnHeader NameCourse;
    }
}