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
            logout = new Button();
            panel3 = new Panel();
            removeTeacher = new Button();
            panel2 = new Panel();
            coursesTeacherListView = new ListView();
            button1 = new Button();
            panel1 = new Panel();
            tprojectcom = new Label();
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
            panel7 = new Panel();
            coursesStudentListView = new ListView();
            showStudentCourses = new Button();
            panel5 = new Panel();
            removeStudent = new Button();
            panel4 = new Panel();
            sprojectcom = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            updateStudent = new Button();
            addStudent = new Button();
            studentSpecialization = new TextBox();
            studentName = new TextBox();
            studentPassword = new TextBox();
            studentEmail = new TextBox();
            studentLabel = new Label();
            studentsDataGridView = new DataGridView();
            tabPage4 = new TabPage();
            panel11 = new Panel();
            courseExamsListView = new ListView();
            showExamsCourse = new Button();
            panel10 = new Panel();
            removeCourse = new Button();
            panel9 = new Panel();
            label9 = new Label();
            updateCourse = new Button();
            label15 = new Label();
            courseLevel = new TextBox();
            label16 = new Label();
            addCourse = new Button();
            courseDescription = new TextBox();
            courseName = new TextBox();
            coursesLabel = new Label();
            coursesDataGridView = new DataGridView();
            tabPage3 = new TabPage();
            button2 = new Button();
            panel8 = new Panel();
            removeExam = new Button();
            panel6 = new Panel();
            examEndTime = new DateTimePicker();
            examStartTime = new DateTimePicker();
            examDate = new DateTimePicker();
            label14 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            examName = new TextBox();
            examDescription = new TextBox();
            addExam = new Button();
            updateExam = new Button();
            examsLabel = new Label();
            examDataGridView = new DataGridView();
            label5 = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teachersDataGridView).BeginInit();
            tabPage1.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).BeginInit();
            tabPage4.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coursesDataGridView).BeginInit();
            tabPage3.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)examDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(813, 1028);
            tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(logout);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(teacherLabel);
            tabPage2.Controls.Add(teachersDataGridView);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(805, 990);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Teacher";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            logout.Location = new Point(680, 37);
            logout.Margin = new Padding(4, 5, 4, 5);
            logout.Name = "logout";
            logout.Size = new Size(107, 50);
            logout.TabIndex = 22;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(removeTeacher);
            panel3.Location = new Point(611, 352);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 77);
            panel3.TabIndex = 16;
            // 
            // removeTeacher
            // 
            removeTeacher.Location = new Point(17, 5);
            removeTeacher.Margin = new Padding(4, 5, 4, 5);
            removeTeacher.Name = "removeTeacher";
            removeTeacher.Size = new Size(140, 63);
            removeTeacher.TabIndex = 9;
            removeTeacher.Text = "Remove";
            removeTeacher.UseVisualStyleBackColor = true;
            removeTeacher.Click += removeTeacher_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(coursesTeacherListView);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(453, 467);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 467);
            panel2.TabIndex = 15;
            // 
            // coursesTeacherListView
            // 
            coursesTeacherListView.Anchor = AnchorStyles.Left;
            coursesTeacherListView.Font = new Font("Segoe UI", 14F);
            coursesTeacherListView.Location = new Point(40, 77);
            coursesTeacherListView.Margin = new Padding(4, 5, 4, 5);
            coursesTeacherListView.Name = "coursesTeacherListView";
            coursesTeacherListView.Size = new Size(201, 367);
            coursesTeacherListView.TabIndex = 13;
            coursesTeacherListView.UseCompatibleStateImageBehavior = false;
            coursesTeacherListView.View = View.Tile;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(40, 13);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(204, 57);
            button1.TabIndex = 12;
            button1.Text = "Show Courses";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(tprojectcom);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(teacherName);
            panel1.Controls.Add(teacherEmail);
            panel1.Controls.Add(teacherPassword);
            panel1.Controls.Add(addTeacher);
            panel1.Controls.Add(updateTeacher);
            panel1.Controls.Add(teacherCollage);
            panel1.Location = new Point(46, 467);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 467);
            panel1.TabIndex = 14;
            // 
            // tprojectcom
            // 
            tprojectcom.AutoSize = true;
            tprojectcom.Font = new Font("Segoe UI", 9F);
            tprojectcom.Location = new Point(267, 133);
            tprojectcom.Margin = new Padding(4, 0, 4, 0);
            tprojectcom.Name = "tprojectcom";
            tprojectcom.Size = new Size(123, 25);
            tprojectcom.TabIndex = 22;
            tprojectcom.Text = "@project.com";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 197);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 15;
            label4.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 133);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 13;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // teacherName
            // 
            teacherName.Font = new Font("Segoe UI", 12F);
            teacherName.Location = new Point(116, 57);
            teacherName.Margin = new Padding(4, 5, 4, 5);
            teacherName.Name = "teacherName";
            teacherName.Size = new Size(141, 39);
            teacherName.TabIndex = 6;
            // 
            // teacherEmail
            // 
            teacherEmail.Font = new Font("Segoe UI", 12F);
            teacherEmail.Location = new Point(116, 120);
            teacherEmail.Margin = new Padding(4, 5, 4, 5);
            teacherEmail.Name = "teacherEmail";
            teacherEmail.Size = new Size(141, 39);
            teacherEmail.TabIndex = 7;
            // 
            // teacherPassword
            // 
            teacherPassword.Font = new Font("Segoe UI", 12F);
            teacherPassword.Location = new Point(116, 183);
            teacherPassword.Margin = new Padding(4, 5, 4, 5);
            teacherPassword.Name = "teacherPassword";
            teacherPassword.Size = new Size(141, 39);
            teacherPassword.TabIndex = 8;
            teacherPassword.UseSystemPasswordChar = true;
            // 
            // addTeacher
            // 
            addTeacher.Location = new Point(24, 342);
            addTeacher.Margin = new Padding(4, 5, 4, 5);
            addTeacher.Name = "addTeacher";
            addTeacher.Size = new Size(107, 92);
            addTeacher.TabIndex = 10;
            addTeacher.Text = "Add";
            addTeacher.UseVisualStyleBackColor = true;
            addTeacher.Click += addTeacher_Click_1;
            // 
            // updateTeacher
            // 
            updateTeacher.Location = new Point(151, 342);
            updateTeacher.Margin = new Padding(4, 5, 4, 5);
            updateTeacher.Name = "updateTeacher";
            updateTeacher.Size = new Size(107, 92);
            updateTeacher.TabIndex = 11;
            updateTeacher.Text = "Update";
            updateTeacher.UseVisualStyleBackColor = true;
            updateTeacher.Click += updateTeacher_Click;
            // 
            // teacherCollage
            // 
            teacherCollage.Font = new Font("Segoe UI", 12F);
            teacherCollage.Location = new Point(116, 247);
            teacherCollage.Margin = new Padding(4, 5, 4, 5);
            teacherCollage.Name = "teacherCollage";
            teacherCollage.Size = new Size(141, 39);
            teacherCollage.TabIndex = 5;
            // 
            // teacherLabel
            // 
            teacherLabel.AutoSize = true;
            teacherLabel.Font = new Font("Segoe UI", 16F);
            teacherLabel.Location = new Point(9, 37);
            teacherLabel.Margin = new Padding(4, 0, 4, 0);
            teacherLabel.Name = "teacherLabel";
            teacherLabel.Size = new Size(149, 45);
            teacherLabel.TabIndex = 3;
            teacherLabel.Text = "Teachers:";
            // 
            // teachersDataGridView
            // 
            teachersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            teachersDataGridView.Location = new Point(9, 92);
            teachersDataGridView.Margin = new Padding(4, 5, 4, 5);
            teachersDataGridView.Name = "teachersDataGridView";
            teachersDataGridView.RowHeadersWidth = 62;
            teachersDataGridView.Size = new Size(779, 250);
            teachersDataGridView.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Controls.Add(panel7);
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(studentLabel);
            tabPage1.Controls.Add(studentsDataGridView);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(805, 990);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Student";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(coursesStudentListView);
            panel7.Controls.Add(showStudentCourses);
            panel7.Location = new Point(461, 458);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(285, 467);
            panel7.TabIndex = 18;
            // 
            // coursesStudentListView
            // 
            coursesStudentListView.Anchor = AnchorStyles.Bottom;
            coursesStudentListView.Font = new Font("Segoe UI", 14F);
            coursesStudentListView.Location = new Point(40, 80);
            coursesStudentListView.Margin = new Padding(4, 5, 4, 5);
            coursesStudentListView.Name = "coursesStudentListView";
            coursesStudentListView.Size = new Size(201, 367);
            coursesStudentListView.TabIndex = 13;
            coursesStudentListView.UseCompatibleStateImageBehavior = false;
            coursesStudentListView.View = View.Tile;
            // 
            // showStudentCourses
            // 
            showStudentCourses.Font = new Font("Segoe UI", 14F);
            showStudentCourses.Location = new Point(40, 13);
            showStudentCourses.Margin = new Padding(4, 5, 4, 5);
            showStudentCourses.Name = "showStudentCourses";
            showStudentCourses.Size = new Size(204, 57);
            showStudentCourses.TabIndex = 12;
            showStudentCourses.Text = "Show Courses";
            showStudentCourses.UseVisualStyleBackColor = true;
            showStudentCourses.Click += showStudentCourses_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(removeStudent);
            panel5.Location = new Point(611, 352);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(175, 74);
            panel5.TabIndex = 17;
            // 
            // removeStudent
            // 
            removeStudent.Location = new Point(20, 5);
            removeStudent.Margin = new Padding(4, 5, 4, 5);
            removeStudent.Name = "removeStudent";
            removeStudent.Size = new Size(137, 62);
            removeStudent.TabIndex = 9;
            removeStudent.Text = "Remove";
            removeStudent.UseVisualStyleBackColor = true;
            removeStudent.Click += removeStudent_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(sprojectcom);
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
            panel4.Location = new Point(56, 458);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(396, 467);
            panel4.TabIndex = 10;
            // 
            // sprojectcom
            // 
            sprojectcom.AutoSize = true;
            sprojectcom.Font = new Font("Segoe UI", 9F);
            sprojectcom.Location = new Point(264, 132);
            sprojectcom.Margin = new Padding(4, 0, 4, 0);
            sprojectcom.Name = "sprojectcom";
            sprojectcom.Size = new Size(123, 25);
            sprojectcom.TabIndex = 21;
            sprojectcom.Text = "@project.com";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 258);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 25);
            label3.TabIndex = 20;
            label3.Text = "Specialization";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 195);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 19;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 132);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 18;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 68);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 17;
            label8.Text = "Name";
            // 
            // updateStudent
            // 
            updateStudent.Location = new Point(151, 342);
            updateStudent.Margin = new Padding(4, 5, 4, 5);
            updateStudent.Name = "updateStudent";
            updateStudent.Size = new Size(107, 92);
            updateStudent.TabIndex = 4;
            updateStudent.Text = "Update";
            updateStudent.UseVisualStyleBackColor = true;
            updateStudent.Click += updateStudent_Click;
            // 
            // addStudent
            // 
            addStudent.Location = new Point(24, 342);
            addStudent.Margin = new Padding(4, 5, 4, 5);
            addStudent.Name = "addStudent";
            addStudent.Size = new Size(107, 92);
            addStudent.TabIndex = 3;
            addStudent.Text = "Add";
            addStudent.UseVisualStyleBackColor = true;
            addStudent.Click += addStudent_Click;
            // 
            // studentSpecialization
            // 
            studentSpecialization.Font = new Font("Segoe UI", 12F);
            studentSpecialization.Location = new Point(116, 249);
            studentSpecialization.Margin = new Padding(4, 5, 4, 5);
            studentSpecialization.Name = "studentSpecialization";
            studentSpecialization.Size = new Size(141, 39);
            studentSpecialization.TabIndex = 8;
            // 
            // studentName
            // 
            studentName.Font = new Font("Segoe UI", 12F);
            studentName.Location = new Point(116, 60);
            studentName.Margin = new Padding(4, 5, 4, 5);
            studentName.Name = "studentName";
            studentName.Size = new Size(141, 39);
            studentName.TabIndex = 5;
            // 
            // studentPassword
            // 
            studentPassword.Font = new Font("Segoe UI", 12F);
            studentPassword.Location = new Point(119, 186);
            studentPassword.Margin = new Padding(4, 5, 4, 5);
            studentPassword.Name = "studentPassword";
            studentPassword.Size = new Size(141, 39);
            studentPassword.TabIndex = 7;
            // 
            // studentEmail
            // 
            studentEmail.Font = new Font("Segoe UI", 12F);
            studentEmail.Location = new Point(116, 118);
            studentEmail.Margin = new Padding(4, 5, 4, 5);
            studentEmail.Name = "studentEmail";
            studentEmail.Size = new Size(141, 39);
            studentEmail.TabIndex = 6;
            // 
            // studentLabel
            // 
            studentLabel.AutoSize = true;
            studentLabel.Font = new Font("Segoe UI", 16F);
            studentLabel.Location = new Point(9, 37);
            studentLabel.Margin = new Padding(4, 0, 4, 0);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new Size(151, 45);
            studentLabel.TabIndex = 1;
            studentLabel.Text = "Students:";
            // 
            // studentsDataGridView
            // 
            studentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsDataGridView.Location = new Point(9, 92);
            studentsDataGridView.Margin = new Padding(4, 5, 4, 5);
            studentsDataGridView.Name = "studentsDataGridView";
            studentsDataGridView.RowHeadersWidth = 62;
            studentsDataGridView.Size = new Size(779, 250);
            studentsDataGridView.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BorderStyle = BorderStyle.Fixed3D;
            tabPage4.Controls.Add(panel11);
            tabPage4.Controls.Add(panel10);
            tabPage4.Controls.Add(panel9);
            tabPage4.Controls.Add(coursesLabel);
            tabPage4.Controls.Add(coursesDataGridView);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Margin = new Padding(4, 5, 4, 5);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(4, 5, 4, 5);
            tabPage4.Size = new Size(805, 990);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Course";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(courseExamsListView);
            panel11.Controls.Add(showExamsCourse);
            panel11.Location = new Point(401, 465);
            panel11.Margin = new Padding(4, 5, 4, 5);
            panel11.Name = "panel11";
            panel11.Size = new Size(285, 467);
            panel11.TabIndex = 19;
            // 
            // courseExamsListView
            // 
            courseExamsListView.Anchor = AnchorStyles.Bottom;
            courseExamsListView.Font = new Font("Segoe UI", 14F);
            courseExamsListView.Location = new Point(40, 90);
            courseExamsListView.Margin = new Padding(4, 5, 4, 5);
            courseExamsListView.Name = "courseExamsListView";
            courseExamsListView.Size = new Size(201, 351);
            courseExamsListView.TabIndex = 13;
            courseExamsListView.UseCompatibleStateImageBehavior = false;
            courseExamsListView.View = View.Tile;
            // 
            // showExamsCourse
            // 
            showExamsCourse.Font = new Font("Segoe UI", 14F);
            showExamsCourse.Location = new Point(40, 13);
            showExamsCourse.Margin = new Padding(4, 5, 4, 5);
            showExamsCourse.Name = "showExamsCourse";
            showExamsCourse.Size = new Size(204, 57);
            showExamsCourse.TabIndex = 12;
            showExamsCourse.Text = "Show Exams";
            showExamsCourse.UseVisualStyleBackColor = true;
            showExamsCourse.Click += showExamsCourse_Click;
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(removeCourse);
            panel10.Location = new Point(611, 352);
            panel10.Margin = new Padding(4, 5, 4, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(175, 74);
            panel10.TabIndex = 18;
            // 
            // removeCourse
            // 
            removeCourse.Location = new Point(20, 5);
            removeCourse.Margin = new Padding(4, 5, 4, 5);
            removeCourse.Name = "removeCourse";
            removeCourse.Size = new Size(133, 62);
            removeCourse.TabIndex = 4;
            removeCourse.Text = "Remove";
            removeCourse.UseVisualStyleBackColor = true;
            removeCourse.Click += removeCourse_Click;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label9);
            panel9.Controls.Add(updateCourse);
            panel9.Controls.Add(label15);
            panel9.Controls.Add(courseLevel);
            panel9.Controls.Add(label16);
            panel9.Controls.Add(addCourse);
            panel9.Controls.Add(courseDescription);
            panel9.Controls.Add(courseName);
            panel9.Location = new Point(43, 565);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(349, 367);
            panel9.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 173);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(51, 25);
            label9.TabIndex = 22;
            label9.Text = "Level";
            // 
            // updateCourse
            // 
            updateCourse.Location = new Point(206, 270);
            updateCourse.Margin = new Padding(4, 5, 4, 5);
            updateCourse.Name = "updateCourse";
            updateCourse.Size = new Size(107, 73);
            updateCourse.TabIndex = 6;
            updateCourse.Text = "Update";
            updateCourse.UseVisualStyleBackColor = true;
            updateCourse.Click += updateCourse_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(40, 118);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(102, 25);
            label15.TabIndex = 21;
            label15.Text = "Description";
            // 
            // courseLevel
            // 
            courseLevel.Font = new Font("Segoe UI", 12F);
            courseLevel.Location = new Point(149, 163);
            courseLevel.Margin = new Padding(4, 5, 4, 5);
            courseLevel.Name = "courseLevel";
            courseLevel.Size = new Size(141, 39);
            courseLevel.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(40, 60);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(59, 25);
            label16.TabIndex = 20;
            label16.Text = "Name";
            // 
            // addCourse
            // 
            addCourse.Location = new Point(19, 270);
            addCourse.Margin = new Padding(4, 5, 4, 5);
            addCourse.Name = "addCourse";
            addCourse.Size = new Size(107, 73);
            addCourse.TabIndex = 5;
            addCourse.Text = "Add";
            addCourse.UseVisualStyleBackColor = true;
            addCourse.Click += addCourse_Click;
            // 
            // courseDescription
            // 
            courseDescription.Font = new Font("Segoe UI", 12F);
            courseDescription.Location = new Point(149, 105);
            courseDescription.Margin = new Padding(4, 5, 4, 5);
            courseDescription.Name = "courseDescription";
            courseDescription.Size = new Size(141, 39);
            courseDescription.TabIndex = 8;
            // 
            // courseName
            // 
            courseName.Font = new Font("Segoe UI", 12F);
            courseName.Location = new Point(149, 47);
            courseName.Margin = new Padding(4, 5, 4, 5);
            courseName.Name = "courseName";
            courseName.Size = new Size(141, 39);
            courseName.TabIndex = 7;
            // 
            // coursesLabel
            // 
            coursesLabel.AutoSize = true;
            coursesLabel.Font = new Font("Segoe UI", 16F);
            coursesLabel.Location = new Point(9, 37);
            coursesLabel.Margin = new Padding(4, 0, 4, 0);
            coursesLabel.Name = "coursesLabel";
            coursesLabel.Size = new Size(140, 45);
            coursesLabel.TabIndex = 3;
            coursesLabel.Text = "Courses:";
            // 
            // coursesDataGridView
            // 
            coursesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursesDataGridView.Location = new Point(9, 92);
            coursesDataGridView.Margin = new Padding(4, 5, 4, 5);
            coursesDataGridView.Name = "coursesDataGridView";
            coursesDataGridView.RowHeadersWidth = 62;
            coursesDataGridView.Size = new Size(779, 250);
            coursesDataGridView.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.BorderStyle = BorderStyle.Fixed3D;
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(panel8);
            tabPage3.Controls.Add(panel6);
            tabPage3.Controls.Add(examsLabel);
            tabPage3.Controls.Add(examDataGridView);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4, 5, 4, 5);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(4, 5, 4, 5);
            tabPage3.Size = new Size(805, 990);
            tabPage3.TabIndex = 4;
            tabPage3.Text = "Exam";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(430, 530);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(249, 228);
            button2.TabIndex = 19;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(removeExam);
            panel8.Location = new Point(611, 352);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(175, 74);
            panel8.TabIndex = 18;
            // 
            // removeExam
            // 
            removeExam.Location = new Point(20, 5);
            removeExam.Margin = new Padding(4, 5, 4, 5);
            removeExam.Name = "removeExam";
            removeExam.Size = new Size(137, 65);
            removeExam.TabIndex = 9;
            removeExam.Text = "Remove";
            removeExam.UseVisualStyleBackColor = true;
            removeExam.Click += removeExam_Click;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(examEndTime);
            panel6.Controls.Add(examStartTime);
            panel6.Controls.Add(examDate);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(examName);
            panel6.Controls.Add(examDescription);
            panel6.Controls.Add(addExam);
            panel6.Controls.Add(updateExam);
            panel6.Location = new Point(34, 433);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(318, 510);
            panel6.TabIndex = 15;
            // 
            // examEndTime
            // 
            examEndTime.CustomFormat = "hh:mm tt";
            examEndTime.Font = new Font("Segoe UI", 12F);
            examEndTime.Format = DateTimePickerFormat.Custom;
            examEndTime.Location = new Point(116, 295);
            examEndTime.Margin = new Padding(4, 5, 4, 5);
            examEndTime.Name = "examEndTime";
            examEndTime.Size = new Size(154, 39);
            examEndTime.TabIndex = 21;
            examEndTime.Value = new DateTime(2024, 12, 18, 0, 41, 0, 0);
            // 
            // examStartTime
            // 
            examStartTime.CustomFormat = "hh:mm tt";
            examStartTime.Font = new Font("Segoe UI", 12F);
            examStartTime.Format = DateTimePickerFormat.Custom;
            examStartTime.ImeMode = ImeMode.Disable;
            examStartTime.Location = new Point(116, 237);
            examStartTime.Margin = new Padding(4, 5, 4, 5);
            examStartTime.Name = "examStartTime";
            examStartTime.Size = new Size(154, 39);
            examStartTime.TabIndex = 20;
            examStartTime.Value = new DateTime(2024, 12, 18, 0, 41, 0, 0);
            // 
            // examDate
            // 
            examDate.CustomFormat = "MM/dd/yyyy";
            examDate.Font = new Font("Segoe UI", 12F);
            examDate.Format = DateTimePickerFormat.Custom;
            examDate.Location = new Point(116, 178);
            examDate.Margin = new Padding(4, 5, 4, 5);
            examDate.Name = "examDate";
            examDate.Size = new Size(154, 39);
            examDate.TabIndex = 19;
            examDate.Value = new DateTime(2024, 12, 17, 0, 0, 0, 0);
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(11, 313);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(80, 25);
            label14.TabIndex = 18;
            label14.Text = "EndTime";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 260);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(86, 25);
            label10.TabIndex = 16;
            label10.Text = "StartTime";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 197);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(49, 25);
            label11.TabIndex = 15;
            label11.Text = "Date";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 133);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(102, 25);
            label12.TabIndex = 13;
            label12.Text = "Description";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 70);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(59, 25);
            label13.TabIndex = 12;
            label13.Text = "Name";
            // 
            // examName
            // 
            examName.Font = new Font("Segoe UI", 12F);
            examName.Location = new Point(116, 57);
            examName.Margin = new Padding(4, 5, 4, 5);
            examName.Name = "examName";
            examName.Size = new Size(154, 39);
            examName.TabIndex = 6;
            // 
            // examDescription
            // 
            examDescription.Font = new Font("Segoe UI", 12F);
            examDescription.Location = new Point(116, 120);
            examDescription.Margin = new Padding(4, 5, 4, 5);
            examDescription.Name = "examDescription";
            examDescription.Size = new Size(154, 39);
            examDescription.TabIndex = 7;
            // 
            // addExam
            // 
            addExam.Location = new Point(11, 388);
            addExam.Margin = new Padding(4, 5, 4, 5);
            addExam.Name = "addExam";
            addExam.Size = new Size(107, 92);
            addExam.TabIndex = 10;
            addExam.Text = "Add";
            addExam.UseVisualStyleBackColor = true;
            addExam.Click += addExam_Click;
            // 
            // updateExam
            // 
            updateExam.Location = new Point(164, 388);
            updateExam.Margin = new Padding(4, 5, 4, 5);
            updateExam.Name = "updateExam";
            updateExam.Size = new Size(107, 92);
            updateExam.TabIndex = 11;
            updateExam.Text = "Update";
            updateExam.UseVisualStyleBackColor = true;
            updateExam.Click += updateExam_Click;
            // 
            // examsLabel
            // 
            examsLabel.AutoSize = true;
            examsLabel.Font = new Font("Segoe UI", 16F);
            examsLabel.Location = new Point(9, 37);
            examsLabel.Margin = new Padding(4, 0, 4, 0);
            examsLabel.Name = "examsLabel";
            examsLabel.Size = new Size(116, 45);
            examsLabel.TabIndex = 5;
            examsLabel.Text = "Exams:";
            // 
            // examDataGridView
            // 
            examDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            examDataGridView.Location = new Point(9, 92);
            examDataGridView.Margin = new Padding(4, 5, 4, 5);
            examDataGridView.Name = "examDataGridView";
            examDataGridView.RowHeadersWidth = 62;
            examDataGridView.Size = new Size(779, 250);
            examDataGridView.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, 256);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 23;
            label5.Text = "Specialization";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 1028);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 5, 4, 5);
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
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coursesDataGridView).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)examDataGridView).EndInit();
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
        private Button button1;
        private ListView coursesTeacherListView;
        private ColumnHeader NameCourse;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel5;
        private TabPage tabPage3;
        private Label examsLabel;
        private DataGridView examDataGridView;
        private Panel panel6;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox examName;
        private TextBox examDescription;
        private Button addExam;
        private Button updateExam;
        private Label label14;
        private DateTimePicker examEndTime;
        private DateTimePicker examStartTime;
        private DateTimePicker examDate;
        private Panel panel7;
        private ListView coursesStudentListView;
        private Button showStudentCourses;
        private Panel panel8;
        private Button removeExam;
        private Label sprojectcom;
        private Panel panel9;
        private Label tprojectcom;
        private Panel panel11;
        private ListView courseExamsListView;
        private Button showExamsCourse;
        private Panel panel10;
        private Label label9;
        private Label label15;
        private Label label16;
        private Button button2;
        private Button logout;
        private Label label5;
    }
}