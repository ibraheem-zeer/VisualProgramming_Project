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
            panel3 = new Panel();
            removeTeacher = new Button();
            panel2 = new Panel();
            coursesTeacherListView = new ListView();
            button1 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            teacherName = new TextBox();
            teacherEmail = new TextBox();
            teacherPassword = new TextBox();
            addTeacher = new Button();
            updateTeacher = new Button();
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
            panel4 = new Panel();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel5 = new Panel();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teachersDataGridView).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coursesDataGridView).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
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
            tabControl1.Size = new Size(771, 617);
            tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(teacherLabel);
            tabPage2.Controls.Add(teachersDataGridView);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(763, 589);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Teacher";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(removeTeacher);
            panel3.Location = new Point(633, 211);
            panel3.Name = "panel3";
            panel3.Size = new Size(123, 45);
            panel3.TabIndex = 16;
            // 
            // removeTeacher
            // 
            removeTeacher.Location = new Point(12, 4);
            removeTeacher.Name = "removeTeacher";
            removeTeacher.Size = new Size(98, 38);
            removeTeacher.TabIndex = 9;
            removeTeacher.Text = "Remove";
            removeTeacher.UseVisualStyleBackColor = true;
            removeTeacher.Click += removeTeacher_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(coursesTeacherListView);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(259, 275);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 281);
            panel2.TabIndex = 15;
            // 
            // coursesTeacherListView
            // 
            coursesTeacherListView.Anchor = AnchorStyles.Bottom;
            coursesTeacherListView.Font = new Font("Segoe UI", 14F);
            coursesTeacherListView.Location = new Point(29, 48);
            coursesTeacherListView.Name = "coursesTeacherListView";
            coursesTeacherListView.Size = new Size(142, 222);
            coursesTeacherListView.TabIndex = 13;
            coursesTeacherListView.UseCompatibleStateImageBehavior = false;
            coursesTeacherListView.View = View.Tile;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(29, 8);
            button1.Name = "button1";
            button1.Size = new Size(142, 34);
            button1.TabIndex = 12;
            button1.Text = "Show Courses";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(teacherName);
            panel1.Controls.Add(teacherEmail);
            panel1.Controls.Add(teacherPassword);
            panel1.Controls.Add(addTeacher);
            panel1.Controls.Add(updateTeacher);
            panel1.Controls.Add(teacherCollage);
            panel1.Location = new Point(26, 275);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 281);
            panel1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 156);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 16;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 118);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 15;
            label4.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 80);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 13;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 42);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // teacherName
            // 
            teacherName.Font = new Font("Segoe UI", 12F);
            teacherName.Location = new Point(81, 34);
            teacherName.Name = "teacherName";
            teacherName.Size = new Size(100, 29);
            teacherName.TabIndex = 6;
            // 
            // teacherEmail
            // 
            teacherEmail.Font = new Font("Segoe UI", 12F);
            teacherEmail.Location = new Point(81, 72);
            teacherEmail.Name = "teacherEmail";
            teacherEmail.Size = new Size(100, 29);
            teacherEmail.TabIndex = 7;
            // 
            // teacherPassword
            // 
            teacherPassword.Font = new Font("Segoe UI", 12F);
            teacherPassword.Location = new Point(81, 110);
            teacherPassword.Name = "teacherPassword";
            teacherPassword.Size = new Size(100, 29);
            teacherPassword.TabIndex = 8;
            teacherPassword.UseSystemPasswordChar = true;
            // 
            // addTeacher
            // 
            addTeacher.Location = new Point(17, 205);
            addTeacher.Name = "addTeacher";
            addTeacher.Size = new Size(75, 55);
            addTeacher.TabIndex = 10;
            addTeacher.Text = "Add";
            addTeacher.UseVisualStyleBackColor = true;
            addTeacher.Click += addTeacher_Click_1;
            // 
            // updateTeacher
            // 
            updateTeacher.Location = new Point(106, 205);
            updateTeacher.Name = "updateTeacher";
            updateTeacher.Size = new Size(75, 55);
            updateTeacher.TabIndex = 11;
            updateTeacher.Text = "Update";
            updateTeacher.UseVisualStyleBackColor = true;
            updateTeacher.Click += updateTeacher_Click;
            // 
            // teacherCollage
            // 
            teacherCollage.Font = new Font("Segoe UI", 12F);
            teacherCollage.Location = new Point(81, 148);
            teacherCollage.Name = "teacherCollage";
            teacherCollage.Size = new Size(100, 29);
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
            teachersDataGridView.Size = new Size(750, 150);
            teachersDataGridView.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(studentLabel);
            tabPage1.Controls.Add(studentsDataGridView);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(763, 589);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Student";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // removeStudent
            // 
            removeStudent.Location = new Point(14, 3);
            removeStudent.Name = "removeStudent";
            removeStudent.Size = new Size(96, 39);
            removeStudent.TabIndex = 9;
            removeStudent.Text = "Remove";
            removeStudent.UseVisualStyleBackColor = true;
            removeStudent.Click += removeStudent_Click;
            // 
            // studentSpecialization
            // 
            studentSpecialization.Font = new Font("Segoe UI", 12F);
            studentSpecialization.Location = new Point(81, 106);
            studentSpecialization.Name = "studentSpecialization";
            studentSpecialization.Size = new Size(100, 29);
            studentSpecialization.TabIndex = 8;
            // 
            // studentPassword
            // 
            studentPassword.Font = new Font("Segoe UI", 12F);
            studentPassword.Location = new Point(81, 142);
            studentPassword.Name = "studentPassword";
            studentPassword.Size = new Size(100, 29);
            studentPassword.TabIndex = 7;
            // 
            // studentEmail
            // 
            studentEmail.Font = new Font("Segoe UI", 12F);
            studentEmail.Location = new Point(81, 71);
            studentEmail.Name = "studentEmail";
            studentEmail.Size = new Size(100, 29);
            studentEmail.TabIndex = 6;
            // 
            // studentName
            // 
            studentName.Font = new Font("Segoe UI", 12F);
            studentName.Location = new Point(81, 36);
            studentName.Name = "studentName";
            studentName.Size = new Size(100, 29);
            studentName.TabIndex = 5;
            // 
            // updateStudent
            // 
            updateStudent.Location = new Point(106, 205);
            updateStudent.Name = "updateStudent";
            updateStudent.Size = new Size(75, 55);
            updateStudent.TabIndex = 4;
            updateStudent.Text = "Update";
            updateStudent.UseVisualStyleBackColor = true;
            updateStudent.Click += updateStudent_Click;
            // 
            // addStudent
            // 
            addStudent.Location = new Point(17, 205);
            addStudent.Name = "addStudent";
            addStudent.Size = new Size(75, 55);
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
            studentsDataGridView.Size = new Size(751, 150);
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
            tabPage4.Size = new Size(763, 589);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Course";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // changeTeacherOfCourse
            // 
            changeTeacherOfCourse.Location = new Point(481, 271);
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
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(updateStudent);
            panel4.Controls.Add(addStudent);
            panel4.Controls.Add(studentSpecialization);
            panel4.Controls.Add(studentName);
            panel4.Controls.Add(studentPassword);
            panel4.Controls.Add(studentEmail);
            panel4.Location = new Point(26, 275);
            panel4.Name = "panel4";
            panel4.Size = new Size(209, 281);
            panel4.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 155);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 20;
            label3.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 117);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 19;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 79);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 18;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 41);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 17;
            label8.Text = "Name";
            // 
            // panel5
            // 
            panel5.Controls.Add(removeStudent);
            panel5.Location = new Point(634, 211);
            panel5.Name = "panel5";
            panel5.Size = new Size(123, 45);
            panel5.TabIndex = 17;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 617);
            Controls.Add(tabControl1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teachersDataGridView).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coursesDataGridView).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
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
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel5;
    }
}