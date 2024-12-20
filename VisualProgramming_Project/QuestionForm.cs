using Project.BLL.Interfaces;
using Project.BLL.repo;
using Project.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgramming_Project
{
    public partial class QuestionForm : Form
    {
        public int examId { get; set; }
        public QuestionForm()
        {
            InitializeComponent();
        }

        QuestionReop questionReop = new QuestionReop();
        void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
        private void LoadQuestion()
        {
            ExamDetails.DataSource = questionReop.GetAllQuestions(examId);
            ExamDetails.Columns[0].Visible = false;
            ExamDetails.Columns[ExamDetails.Columns.Count - 1].Visible = false;
            ExamDetails.Columns[ExamDetails.Columns.Count - 2].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var question = new Question()
            {
                Title = textBox1.Text,
                Choice1 = textBox2.Text,
                Choice2 = textBox3.Text,
                Choice3 = textBox4.Text,
                Choice4 = textBox5.Text,
                Answer = textBox6.Text,
                ExamId = examId
            };
            questionReop.AddQuestion(question);
            Clear();
            LoadQuestion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ExamDetails.CurrentRow.Cells["Id"].Value);
            questionReop.DeleteQuestion(id);
            LoadQuestion();
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            LoadQuestion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ExamDetails.CurrentRow.Cells["Id"].Value);
            Question question = new Question();
            if (textBox1.Text != "")
            {
                question.Title = textBox1.Text;
            }
            if (textBox2.Text != "")
            {
                question.Choice1 = textBox2.Text;
            }
            if (textBox3.Text != "")
            {
                question.Choice2 = textBox3.Text;
            }
            if (textBox4.Text != "")
            {
                question.Choice3 = textBox4.Text;
            }
            if (textBox5.Text != "")
            {
                question.Choice4 = textBox5.Text;
            }
            if (textBox6.Text != "")
            {
                question.Answer = textBox6.Text;
            }
            questionReop.UpdateQuestion(question);
            LoadQuestion();
            Clear();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form1"]?.Show();
            this.Close();
        }
    }
}
