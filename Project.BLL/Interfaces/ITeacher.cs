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
        string Login(string Email, string Password);
        Teacher GetTeacherByEmail(string email);
        ICollection<Exam> ViewExams(int id);
        void CompleteExam(int id);
        ICollection<Course> ViewAssignedCourse(string email);
        int ViewResultOfExam(int id);
    }
}
