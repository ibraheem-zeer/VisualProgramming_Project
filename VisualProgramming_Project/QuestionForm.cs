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
            if (textBox1.Text.Equals("")
                ||textBox2.Text.Equals("")
                || textBox3.Text.Equals("")
                || textBox4.Text.Equals("")
                || textBox5.Text.Equals("")
                || textBox6.Text.Equals("")) 
            {
                MessageBox.Show("write data in boxes");
                return;
            }
            if (textBox1.Text.Equals(textBox6.Text)
                || textBox2.Text.Equals(textBox6.Text)
                || textBox3.Text.Equals(textBox6.Text)
                || textBox4.Text.Equals(textBox6.Text)
                || textBox5.Text.Equals(textBox6.Text)
                || textBox6.Text.Equals(textBox6.Text))
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
            else MessageBox.Show("The answer didnt match");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ExamDetails.CurrentRow == null)
            {
                MessageBox.Show("Select the Exam !!!!!!!!!");
                return;
            }
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
            if (ExamDetails.CurrentRow == null)
            {
                MessageBox.Show("Select the Exam !!!!!!!!!");
                return;
            }
            int id = Convert.ToInt32(ExamDetails.CurrentRow.Cells["Id"].Value);

            Question question = questionReop.getQuestion(id);

            if (textBox1.Text != "")
                question.Title = textBox1.Text;
            if (textBox2.Text != "")
                question.Choice1 = textBox2.Text;
            if (textBox3.Text != "")
                question.Choice2 = textBox3.Text;
            if (textBox4.Text != "")
                question.Choice3 = textBox4.Text;
            if (textBox5.Text != "")
                question.Choice4 = textBox5.Text;
            if (textBox6.Text != "")
                question.Answer = textBox6.Text;

            questionReop.UpdateQuestion(question);
            LoadQuestion();
            Clear();
        }
    }
}
