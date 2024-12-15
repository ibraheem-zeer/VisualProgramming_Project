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
            updateTeacher = new Button();
            addTeacher = new Button();
            removeTeacher = new Button();
            TeacherPassword = new TextBox();
            TeacherEmail = new TextBox();
            TeacherName = new TextBox();
            TeacherCollage = new TextBox();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            tabPage1 = new TabPage();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tabPage4 = new TabPage();
            label3 = new Label();
            dataGridView3 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(877, 613);
            tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(updateTeacher);
            tabPage2.Controls.Add(addTeacher);
            tabPage2.Controls.Add(removeTeacher);
            tabPage2.Controls.Add(TeacherPassword);
            tabPage2.Controls.Add(TeacherEmail);
            tabPage2.Controls.Add(TeacherName);
            tabPage2.Controls.Add(TeacherCollage);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(869, 585);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Teacher";
            tabPage2.UseVisualStyleBackColor = true;
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
            removeTeacher.Location = new Point(306, 211);
            removeTeacher.Name = "removeTeacher";
            removeTeacher.Size = new Size(223, 23);
            removeTeacher.TabIndex = 9;
            removeTeacher.Text = "Remove";
            removeTeacher.UseVisualStyleBackColor = true;
            removeTeacher.Click += removeTeacher_Click;
            // 
            // TeacherPassword
            // 
            TeacherPassword.Font = new Font("Segoe UI", 14F);
            TeacherPassword.Location = new Point(40, 372);
            TeacherPassword.Name = "TeacherPassword";
            TeacherPassword.Size = new Size(100, 32);
            TeacherPassword.TabIndex = 8;
            TeacherPassword.UseSystemPasswordChar = true;
            // 
            // TeacherEmail
            // 
            TeacherEmail.Font = new Font("Segoe UI", 14F);
            TeacherEmail.Location = new Point(40, 334);
            TeacherEmail.Name = "TeacherEmail";
            TeacherEmail.Size = new Size(100, 32);
            TeacherEmail.TabIndex = 7;
            // 
            // TeacherName
            // 
            TeacherName.Font = new Font("Segoe UI", 14F);
            TeacherName.Location = new Point(40, 296);
            TeacherName.Name = "TeacherName";
            TeacherName.Size = new Size(100, 32);
            TeacherName.TabIndex = 6;
            // 
            // TeacherCollage
            // 
            TeacherCollage.Font = new Font("Segoe UI", 14F);
            TeacherCollage.Location = new Point(40, 410);
            TeacherCollage.Name = "TeacherCollage";
            TeacherCollage.Size = new Size(100, 32);
            TeacherCollage.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(97, 30);
            label2.TabIndex = 3;
            label2.Text = "Teachers";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 55);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(856, 150);
            dataGridView2.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(869, 585);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Student";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(96, 30);
            label1.TabIndex = 1;
            label1.Text = "Students";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(856, 150);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(dataGridView3);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(869, 585);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Course";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(4, 19);
            label3.Name = "label3";
            label3.Size = new Size(90, 30);
            label3.TabIndex = 3;
            label3.Text = "Courses";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(4, 52);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(856, 150);
            dataGridView3.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label3;
        private DataGridView dataGridView3;
        private TextBox TeacherCollage;
        private TextBox TeacherPassword;
        private TextBox TeacherEmail;
        private TextBox TeacherName;
        private Button removeTeacher;
        private Button updateTeacher;
        private Button addTeacher;
    }
}