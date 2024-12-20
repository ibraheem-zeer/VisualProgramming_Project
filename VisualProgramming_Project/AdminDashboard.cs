using Microsoft.VisualBasic.Logging;
using Project.BLL.repo;
using Project.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming_Project
{
    public partial class AdminDashboard : Form
    {

        AdminRepo admin = new AdminRepo();
        public AdminDashboard()
        {
            InitializeComponent();
        }
        void ClearTeacher()
        {
            teacherName.Clear();
            teacherEmail.Clear();
            teacherCollage.Clear();
            teacherPassword.Clear();
        }
        void LoadTeachers()
        {
            teachersDataGridView.DataSource = admin.GetAllTeachers();
            teacherLabel.Text = $"Teachers: {admin.GetAllTeachers().Count} ";
            teachersDataGridView.Columns[teachersDataGridView.Columns.Count - 1].Visible = false;
            teachersDataGridView.Columns[teachersDataGridView.Columns.Count - 2].Visible = false;

        }
        void ClearStudent()
        {
            studentName.Clear();
            studentEmail.Clear();
            studentSpecialization.Clear();
            studentPassword.Clear();
        }
        void LoadStudents()
        {
            studentsDataGridView.DataSource = admin.GetAllStudents();
            studentLabel.Text = $"Students: {admin.GetAllStudents().Count} ";
            studentsDataGridView.Columns[studentsDataGridView.Columns.Count - 1].Visible = false;
            studentsDataGridView.Columns[studentsDataGridView.Columns.Count - 2].Visible = false;
        }
        void ClearCourse()
        {
            courseName.Clear();
            courseDescription.Clear();
            courseLevel.Clear();
        }
        void LoadCourses()
        {
            coursesDataGridView.DataSource = admin.GetAllCourses();
            coursesLabel.Text = $"Courses: {admin.GetAllCourses().Count} ";
            //coursesDataGridView.Columns[coursesDataGridView.Columns.Count - 1].Visible = false;
            //coursesDataGridView.Columns[coursesDataGridView.Columns.Count - 2].Visible = false;
        }
        void ClearExam()
        {
            examName.Clear();
            examDescription.Clear();
        }
        void LoadExams()
        {
            examDataGridView.DataSource = admin.GetAllExams();
            examsLabel.Text = $"Courses: {admin.GetAllExams().Count} ";
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadStudents();
            LoadTeachers();
            LoadExams();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Teacher teacher = new Teacher()
            {
                Name = teacherName.Text,
                collage = teacherCollage.Text,
                Email = teacherEmail.Text,
                Password = teacherPassword.Text,
            };

            admin.CreateTeacher(teacher);
            LoadTeachers();
            ClearTeacher();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(teachersDataGridView.CurrentCell.Value);
            admin.DeleteTeacher(id);
            LoadTeachers();
        }
        private void addTeacher_Click(object sender, EventArgs e)
        {

            Teacher teacher = new Teacher()
            {
                Name = teacherName.Text,
                collage = teacherCollage.Text,
                Email = teacherEmail.Text,
                Password = teacherPassword.Text,
            };

            admin.UpdateTeacher(teacher);
            LoadTeachers();
            ClearTeacher();
        }

        private void removeTeacher_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(teachersDataGridView.CurrentCell.Value);
            admin.DeleteTeacher(id);
            LoadTeachers();
        }

        private void addTeacher_Click_1(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher()
            {
                Name = teacherName.Text,
                collage = teacherCollage.Text,
                Email = "t" + teacherEmail.Text + tprojectcom.Text,
                Password = teacherPassword.Text,
            };

            admin.CreateTeacher(teacher);
            LoadTeachers();
            ClearTeacher();
        }

        private void updateTeacher_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(teachersDataGridView.CurrentCell.Value);
            Teacher teacher = admin.GetTeacher(id);
            if (teacherName.Text != "")
            {
                teacher.Name = teacherName.Text;
            }
            if (teacherEmail.Text != "")
            {
                teacher.Email = teacherEmail.Text;
            }
            if (teacherPassword.Text != "")
            {
                teacher.Password = teacherPassword.Text;
            }
            if (teacherCollage.Text != "")
            {
                teacher.collage = teacherCollage.Text;
            }
            admin.UpdateTeacher(teacher);
            LoadTeachers();
            ClearTeacher();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = studentName.Text,
                Specialization = studentSpecialization.Text,
                Email = "s" + studentEmail.Text + sprojectcom.Text,
                Password = studentPassword.Text,
            };

            admin.CreateStudent(student);
            LoadStudents();
            ClearStudent();
        }

        private void removeStudent_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(studentsDataGridView.CurrentCell.Value);
            admin.DeleteStudent(id);
            LoadStudents();
        }

        private void updateStudent_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(studentsDataGridView.CurrentCell.Value);
            Student student = admin.GetStudent(id);
            if (studentName.Text != "")
            {
                student.Name = studentName.Text;
            }
            if (studentEmail.Text != "")
            {
                student.Email = studentEmail.Text;
            }
            if (studentPassword.Text != "")
            {
                student.Password = studentPassword.Text;
            }
            if (studentSpecialization.Text != "")
            {
                student.Specialization = studentSpecialization.Text;
            }
            admin.UpdateStudent(student);
            LoadStudents();
            ClearStudent();
        }

        private void addCourse_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(teachersDataGridView.CurrentCell.Value);

            Course course = new Course()
            {
                Name = courseName.Text,
                Description = courseDescription.Text,
                Level = int.Parse(courseLevel.Text),
                TeacherId = id,
            };

            admin.CreateCourse(course);
            LoadCourses();
            ClearCourse();
        }

        private void updateCourse_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(coursesDataGridView.CurrentCell.Value);
            Course course = admin.GetCourse(id);
            if (courseName.Text != "")
            {
                course.Name = courseName.Text;
            }
            if (courseDescription.Text != "")
            {
                course.Description = courseDescription.Text;
            }
            if (courseLevel.Text != "")
            {
                course.Level = int.Parse(courseLevel.Text);
            }

            admin.UpdateCourse(course);
            LoadCourses();
            ClearCourse();
        }

        private void removeCourse_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(coursesDataGridView.CurrentCell.Value);
            admin.DeleteCourse(id);
            LoadCourses();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(teachersDataGridView.CurrentCell.Value);
            Teacher teacher = admin.GetTeacher(id);
            coursesTeacherListView.Items.Clear();
            if (teacher.Courses != null)
            {
                foreach (var t in teacher.Courses)
                {
                    coursesTeacherListView.Items.Add(t.Name);
                }
            }
            else
            {
                MessageBox.Show("Teacher has not assagin in courses");
            }
        }

        private void addExam_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(coursesDataGridView.CurrentCell.Value);
            Course course = admin.GetCourse(id);

            Exam exam = new Exam()
            {
                Name = examName.Text,
                Description = examDescription.Text,
                Date = examDate.Value.Date,
                StartTime = examStartTime.Value.TimeOfDay,
                EndTime = examEndTime.Value.TimeOfDay,
                Course = course,
            };

            admin.CreateExam(exam);
            LoadExams();
            ClearExam();
        }

        private void showStudentCourses_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(studentsDataGridView.CurrentCell.Value);
            Student student = admin.GetStudent(id);
            coursesStudentListView.Items.Clear();

            if (student.Courses != null)
            {
                foreach (var t in student.Courses)
                {
                    coursesTeacherListView.Items.Add(t.Course.Name);
                }
            }
            else
            {
                MessageBox.Show("Student has not assagin in courses");
            }
        }

        private void showExamsCourse_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(coursesDataGridView.CurrentCell.Value);

            Course course = admin.GetCourse(id);
            courseExamsListView.Items.Clear();

            if (course.Exams != null)
            {
                foreach (var t in course.Exams)
                {
                    courseExamsListView.Items.Add(t.Name);
                }
            }
            else
            {
                MessageBox.Show("Student has not assagin in courses");
            }
        }

        private void removeExam_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(examDataGridView.CurrentCell.Value);
            admin.DeleteExam(id);
            LoadExams();
        }

        private void updateExam_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(examDataGridView.CurrentCell.Value);
            Exam exam = admin.GetExam(id);
            if (examName.Text != "")
            {
                exam.Name = examName.Text;
            }
            if (examDescription.Text != "")
            {
                exam.Description = examDescription.Text;
            }
            if (examDate.Text != "")
            {
                exam.Date = DateTime.Parse(examDate.Text);
            }
            if (examStartTime.Text != "")
            {
                exam.StartTime = TimeSpan.Parse(examDate.Text + " " + examStartTime.Text);
            }
            if (examEndTime.Text != "")
            {
                exam.EndTime = TimeSpan.Parse(examDate.Text + " " + examEndTime.Text);
            }
            admin.UpdateExam(exam);
            LoadExams();
            ClearExam();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"]?.Show();
            this.Close();
        }

    }
}
