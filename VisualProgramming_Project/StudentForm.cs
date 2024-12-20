using Microsoft.VisualBasic.Devices;
using Project.BLL.Interfaces;
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
using VisualProgramming_Project.Helpers;

namespace VisualProgramming_Project
{
    public partial class StudentForm : Form
    {
        public Student thisStudent = new Student();
        StudentRepo studentRepo = new StudentRepo();

        public StudentForm()
        {
            InitializeComponent();
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            coursesDataGridView.DataSource = studentRepo.GetAllCourses();
            coursesDataGridView.Columns[0].Visible = false;
            coursesDataGridView.Columns[1].Visible = false;
            LoadAssignCourses();
        }
        void LoadAssignCourses()
        {
            yourCoursesDataGridView.DataSource = studentRepo.GetAllAssignCourses(thisStudent.Id)
                .Select(x => new
                {
                    Id = x.Id,
                    CourseName = x.Name,
                    TeacherName = x.Teacher.Name
                }).ToList();
            yourCoursesDataGridView.Columns[0].Visible = false;
            //yourCoursesDataGridView.Columns[yourCoursesDataGridView.Columns.Count -1 ].Visible = false;
            //yourCoursesDataGridView.Columns[yourCoursesDataGridView.Columns.Count -2 ].Visible = false;
            //yourCoursesDataGridView.Columns[yourCoursesDataGridView.Columns.Count -3 ].Visible = false;
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
        private void startExam_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(examsDataGridView.CurrentRow.Cells["Id"].Value);
            var questions = studentRepo.DoExam(id);
            if(questions is null)
            {
                MessageBox.Show("Don't Cheat man!");
            }
            else
            {
                var studentExam = new StudentExam()
                {
                    StudentId = thisStudent.Id,
                    ExamId = id,
                    Result = GHelpers.result
                };
                AnswerQuestionsForm answerQuestionsForm;
                foreach (var question in questions)
                {
                    answerQuestionsForm = new AnswerQuestionsForm(question);
                    answerQuestionsForm.ShowDialog();
                }
            }
        }

        private void rollCourse_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(coursesDataGridView.CurrentRow.Cells["Id"].Value);
            Course course = studentRepo.GetCourse(id);

            if(course.Key.ToString() == CouresKey.Text)
            {
                StudentCourse? existingCourse = thisStudent.Courses.FirstOrDefault(c => c.CourseId == id);

                if (existingCourse == null)
                {

                    StudentCourse studentCourse = new StudentCourse()
                    {
                        CourseId = course.Id,
                        Course = course,
                    };
                    thisStudent.Courses.Add(studentCourse);
                    studentRepo.UpdateStudent(thisStudent);

                    LoadAssignCourses();

                }
                else
                {
                    MessageBox.Show("Student has assagin in this course");
                }
            }else
            {
                MessageBox.Show("Hmmmm!!! it seems you want to steal this course , Go Away...");
            }
        }

        private void yourCoursesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = Convert.ToInt32(yourCoursesDataGridView.CurrentRow.Cells["Id"].Value);

            List<Exam> exams = studentRepo.GetExams(id).ToList();
            if (exams == null || !exams.Any())
            {
                examsDataGridView.DataSource = null;
                MessageBox.Show("No exams found for the selected course.");
                return;
            }

            LoadCourseExam(exams);

        }

        private void unRoll_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(coursesDataGridView.CurrentRow.Cells["Id"].Value);

            Course course = studentRepo.GetCourse(id);
            List<StudentCourse> courses = studentRepo.GetAllStudentCourses(thisStudent.Id).ToList();
            StudentCourse existingCourse = courses.FirstOrDefault(e => e.StudentId == thisStudent.Id);

            if (existingCourse != null)
            {
                studentRepo.Enroll(existingCourse);

                LoadAssignCourses();

            }
            else
            {
                MessageBox.Show("Student removed form this course");
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"]?.Show();
            this.Close();
        }
    }
}
