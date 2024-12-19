using Project.BLL.repo;

namespace VisualProgramming_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TeacherRepo teacherRepo = new TeacherRepo();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                AdminDashboard admin = new AdminDashboard();
                admin.Show();
                this.Hide();
            }
            else if (textBox1.Text[0] == 't')
            {
                var email = textBox1.Text;
                var password = textBox2.Text;
                var login = teacherRepo.Login(email, password);
                TeacherForm teacherForm = new TeacherForm();
                teacherForm.TeacherEmail = email;
                teacherForm.Show();
                this.Hide();
            }
            else if (textBox1.Text[0] == 's')
            {

            }
            else MessageBox.Show("wait a minute who are you ?");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
