using Project.BLL.Interfaces;
using Project.DAL.Data;
using Project.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.repo
{
    public class QuestionReop : IQuestion
    {
        AppDbContext context = new AppDbContext();
        public string AddQuestion(Question question)
        {
            try
            {
                if (question == null) return "there is something wrong!";
                context.Questions.Add(question);
                context.SaveChanges();
                return "Question Added successfully!";
            }
            catch
            {
                return "Internal Server Error!";
            }
        }

        public string DeleteQuestion(int id)
        {
            try
            {
                var findQuestion = context.Questions.Find(id);
                context.Questions.Remove(findQuestion);
                return "Question Deleted Successfully";
            }
            catch
            {
                return "Internal Server Error!";
            }

        }

        public ICollection<Question> GetAllQuestions(int id) => context.Questions.Where(x => x.ExamId == id).ToList();

        public string UpdateQuestion(Question question)
        {
            var findQuestion = context.Questions.Find(question.Id);
            if (findQuestion == null) return "there is no Question";
            context.Questions.Update(question);
            context.SaveChanges();
            return "Updated Successfully";
        }
    }
}
