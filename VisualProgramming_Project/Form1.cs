using Project.BLL.repo;
using Project.DAL.Data.Models;

namespace VisualProgramming_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void clearText() { 
            textBox1.Clear();
            textBox2.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                AdminDashboard admin = new AdminDashboard();
                admin.Show();
                this.Hide();
                clearText();
            }

        }
    }
}
