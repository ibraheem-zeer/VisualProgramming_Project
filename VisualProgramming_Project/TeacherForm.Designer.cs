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
            TeacherCoursesList = new ListView();
            SuspendLayout();
            // 
            // TeacherCoursesList
            // 
            TeacherCoursesList.Location = new Point(141, 84);
            TeacherCoursesList.Name = "TeacherCoursesList";
            TeacherCoursesList.Size = new Size(474, 275);
            TeacherCoursesList.TabIndex = 0;
            TeacherCoursesList.UseCompatibleStateImageBehavior = false;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TeacherCoursesList);
            Name = "TeacherForm";
            Text = "TeacherForm";
            Load += TeacherForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView TeacherCoursesList;
    }
}