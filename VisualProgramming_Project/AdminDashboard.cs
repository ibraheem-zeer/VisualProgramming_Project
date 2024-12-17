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
        void LoadTeacher()
        {
            teachersDataGridView.DataSource = admin.GetAllTeachers();
            teacherLabel.Text = $"Teachers: {admin.GetAllTeachers().Count} ";
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
        }
        void ClearCourse()
        {
            courseName.Clear();
            courseDescription.Clear();
            courseLevel.Clear();
        }
        void LoadCourse()
        {
            coursesDataGridView.DataSource = admin.GetAllCourses();
            coursesLabel.Text = $"Courses: {admin.GetAllCourses().Count} ";
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            studentsDataGridView.DataSource = admin.GetAllStudents();
            studentLabel.Text = $"Students: {admin.GetAllStudents().Count} ";
            teachersDataGridView.DataSource = admin.GetAllTeachers();
            teacherLabel.Text = $"Teachers: {admin.GetAllTeachers().Count} ";
            coursesDataGridView.DataSource = admin.GetAllCourses();
            coursesLabel.Text = $"Courses: {admin.GetAllCourses().Count} ";
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
            LoadTeacher();
            ClearTeacher();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(teachersDataGridView.CurrentCell.Value);
            admin.DeleteTeacher(id);
            LoadTeacher();
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
            LoadTeacher();
            ClearTeacher();
        }

        private void removeTeacher_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(teachersDataGridView.CurrentCell.Value);
            admin.DeleteTeacher(id);
            LoadTeacher();
        }

        private void addTeacher_Click_1(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher()
            {
                Name = teacherName.Text,
                collage = teacherCollage.Text,
                Email = teacherEmail.Text,
                Password = teacherPassword.Text,
            };

            admin.CreateTeacher(teacher);
            LoadTeacher();
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
            LoadTeacher();
            ClearTeacher();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = studentName.Text,
                Specialization = studentSpecialization.Text,
                Email = studentEmail.Text,
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
            Teacher teacher = admin.GetTeacher(id);

            Course course = new Course()
            {
                Name = courseName.Text,
                Description = courseDescription.Text,
                Level = int.Parse(courseLevel.Text),
                Teacher = teacher,
            };

            admin.CreateCourse(course);
            LoadTeacher();
            LoadCourse();
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
            LoadCourse();
            ClearCourse();
        }

        private void changeTeacherOfCourse_Click(object sender, EventArgs e)
        {
            int courseid = Convert.ToInt32(coursesDataGridView.CurrentCell.Value);
            Course course = admin.GetCourse(courseid);
            int teacherid = Convert.ToInt32(teachersDataGridView.CurrentCell.Value);
            Teacher teacher = admin.GetTeacher(teacherid);

            course.Teacher = teacher;
            admin.UpdateCourse(course);
            LoadCourse();
            ClearCourse();
        }

        private void removeCourse_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(coursesDataGridView.CurrentCell.Value);
            admin.DeleteCourse(id);
            LoadCourse();
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

      
    }
}
