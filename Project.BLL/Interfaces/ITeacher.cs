using Project.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Interfaces
{
    internal interface ITeacher
    {
        void Login(string Email, string Password);
        ICollection<Exam> ViewExams(Exam exam);
        void CompleteExam(int id);
        ICollection<Course> ViewAssignedCourse();
        int ViewResultOfExam(int id);
    }
}
