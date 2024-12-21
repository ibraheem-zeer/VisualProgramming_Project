using Project.BLL.repo;
using Project.DAL.Data.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VisualProgramming_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TeacherRepo teacherRepo = new TeacherRepo();
        void clearText() { 
            textBox1.Clear();
            textBox2.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var email = textBox1.Text;
            var password = textBox2.Text;
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                AdminDashboard admin = new AdminDashboard();
                admin.Show();
                this.Hide();
                clearText();
            }
            else if (textBox1.Text[0] == 't')
            {
                var login = teacherRepo.Login(email, password);
                TeacherForm teacherForm = new TeacherForm();
                teacherForm.TeacherEmail = email;
                teacherForm.Show();
                this.Hide();
            }
            else if (textBox1.Text[0] == 's')
            {
                StudentRepo studentRepo = new StudentRepo();
                Student student = studentRepo.Login(email, password);
                if (student != null)
                {
                    StudentForm studentForm = new StudentForm();
                    studentForm.thisStudent = student;
                    studentForm.Show();
                    this.Hide();
                    clearText();
                }
                else MessageBox.Show("wait a minute who are you ?");
            }
        }
    }
}
