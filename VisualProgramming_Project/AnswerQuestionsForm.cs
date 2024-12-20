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
    public partial class AnswerQuestionsForm : Form
    {

        private Question question { get; set; }

        public AnswerQuestionsForm(Question question)
        {
            InitializeComponent();
            this.question = question;
            label1.Text = question.Title;
            radioButton1.Text = question.Choice1;
            radioButton2.Text = question.Choice2;
            radioButton3.Text = question.Choice3;
            radioButton4.Text = question.Choice4;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && radioButton1.Text == question.Answer) GHelpers.result++;
       
            
            if (radioButton2.Checked && radioButton2.Text == question.Answer) GHelpers.result++;
       

            if (radioButton3.Checked && radioButton3.Text == question.Answer) GHelpers.result++;

            if (radioButton4.Checked && radioButton4.Text == question.Answer) GHelpers.result++;
            
            this.Close();
        }
    }
}
