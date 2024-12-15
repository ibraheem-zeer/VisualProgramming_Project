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

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = admin.GetAllStudents();
            label1.Text = $"Students: {admin.GetAllStudents().Count} ";
            dataGridView2.DataSource = admin.GetAllTeachers();
            label2.Text = $"Teachers: {admin.GetAllTeachers().Count} ";
            dataGridView3.DataSource = admin.GetAllCourses();
            label3.Text = $"Courses: {admin.GetAllCourses().Count} ";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Teacher teacher = new Teacher()
            {
                Name = TeacherName.Text,
                collage = TeacherCollage.Text,
                Email = TeacherEmail.Text,
                Password = TeacherPassword.Text,
            };

            admin.CreateTeacher(teacher);
            LoadTeacher();
            ClearTeacher();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView2.CurrentCell.Value);
            admin.DeleteTeacher(id);
            LoadTeacher();
        }
        private void addTeacher_Click(object sender, EventArgs e)
        {

            Teacher teacher = new Teacher()
            {
                Name = TeacherName.Text,
                collage = TeacherCollage.Text,
                Email = TeacherEmail.Text,
                Password = TeacherPassword.Text,
            };

            admin.UpdateTeacher(teacher);
            LoadTeacher();
            ClearTeacher();
        }






        void ClearTeacher()
        {
            TeacherName.Clear();
            TeacherEmail.Clear();
            TeacherCollage.Clear();
            TeacherPassword.Clear();
        }
        void LoadTeacher()
        {
            dataGridView2.DataSource = admin.GetAllTeachers();
            label2.Text = $"Teachers: {admin.GetAllTeachers().Count} ";
        }

        private void removeTeacher_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView2.CurrentCell.Value);
            admin.DeleteTeacher(id);
            LoadTeacher();
        }

        private void addTeacher_Click_1(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher()
            {
                Name = TeacherName.Text,
                collage = TeacherCollage.Text,
                Email = TeacherEmail.Text,
                Password = TeacherPassword.Text,
            };

            admin.CreateTeacher(teacher);
            LoadTeacher();
            ClearTeacher();
        }

        private void updateTeacher_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView2.CurrentCell.Value);
            Teacher teacher = admin.GetTeacher(id);
            if (TeacherName.Text != "")
            {
                teacher.Name = TeacherName.Text;
            }
            if (TeacherEmail.Text != "")
            {
                teacher.Email = TeacherEmail.Text;
            }
            if (TeacherPassword.Text != "")
            {
                teacher.Password = TeacherPassword.Text;
            }
            if (TeacherCollage.Text != "")
            {
                teacher.collage = TeacherCollage.Text;
            }
            admin.UpdateTeacher(teacher);
            LoadTeacher();
            ClearTeacher();
        }
    }
}
