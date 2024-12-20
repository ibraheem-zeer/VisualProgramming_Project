using Project.BLL.repo;
using Project.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming_Project
{
    public partial class TeacherForm : Form
    {

        public string TeacherEmail { get; set; }
        TeacherRepo teacherRepo = new TeacherRepo();
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            var teacherEmail = teacherRepo.GetTeacherByEmail(TeacherEmail);
            var courses = teacherRepo.ViewAssignedCourse(TeacherEmail);
            foreach (var course in courses)
            {
                TeacherCoursesList.Items.Add(course.Name, course.Description);
            }
            LoadAssignCourses();
        }

        private void TeacherCoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void LoadAssignCourses()
        {
            yourCoursesDataGridView.DataSource = teacherRepo.ViewAssignedCourse(TeacherEmail)
                .Select(x => new
                {
                    Id = x.Id,
                    CourseName = x.Name,
                }).ToList();
            yourCoursesDataGridView.Columns[0].Visible = false;
        }
        void LoadCourseExam(List<Exam> exams)
        {
            examsDataGridView.DataSource = exams;
            examsDataGridView.Columns[0].Visible = false;
            examsDataGridView.Columns[examsDataGridView.Columns.Count - 1].Visible = false;
            examsDataGridView.Columns[examsDataGridView.Columns.Count - 2].Visible = false;
            examsDataGridView.Columns[examsDataGridView.Columns.Count - 3].Visible = false;
            examsDataGridView.Columns[examsDataGridView.Columns.Count - 4].Visible = false;
        }

        private void yourCoursesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(yourCoursesDataGridView.CurrentRow.Cells["Id"].Value);

            List<Exam> exams = teacherRepo.ViewExams(id).ToList();
            if (exams == null || !exams.Any())
            {
                examsDataGridView.DataSource = null;
                MessageBox.Show("No exams found for the selected course.");
                return;
            }

            LoadCourseExam(exams);
        }

        private void CompleteExam_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(examsDataGridView.CurrentRow.Cells["Id"].Value);
            QuestionForm questionForm = new QuestionForm();
            questionForm.examId = id;
            questionForm.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"]?.Show();
            this.Close();
        }

        private void seeResult_Click(object sender, EventArgs e)
        {

        }
    }
}
