using Project.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Interfaces
{
    internal interface IQuestion
    {
        string AddQuestion(Question question);
        string UpdateQuestion(Question question);
        string DeleteQuestion(int id);

        ICollection<Question> GetAllQuestions(int id);
    }
}
