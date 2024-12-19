using Project.BLL.repo;
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
        }
    }
}
