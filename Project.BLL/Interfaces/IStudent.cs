using Project.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Interfaces
{
    internal interface IStudent
    {
        ICollection<Course> GetAllCourses();
        ICollection<Course> GetAllAssignCourses(int id);
        ICollection<StudentCourse> GetAllStudentCourses(int id);
        Course GetCourse(int id);
        ICollection<Exam> GetExams(int idCourse);
        ICollection<Question> GetQuestion(int idExam);
        string UpdateStudent(Student student);
        Student Login(string Email, string Password);
        string Enroll(StudentCourse studentcourse);
        string DoExam(int id);
        string SeeResult(int id);
    }
}
