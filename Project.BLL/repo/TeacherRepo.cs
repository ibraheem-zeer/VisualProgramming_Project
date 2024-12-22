using Microsoft.EntityFrameworkCore;
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
    public class TeacherRepo : ITeacher
    {
        AppDbContext context = new AppDbContext();

        public Teacher GetTeacherByEmail(string email)
        {
            var findEmail = context.Teachers.FirstOrDefault(t => t.Email == email);
            if (findEmail is null) return null;
            return findEmail;
        }

        public string Login(string Email, string Password)
        {
            var email = context.Teachers.FirstOrDefault(x => x.Email == Email);
            if(email == null || email.Password != Password) return "Email or Password are invalid!";
            return email.Email;
        }

        public ICollection<Course> ViewAssignedCourse(string email)
        {
            var findEmail = GetTeacherByEmail(email);
            if(findEmail != null)
                return context.Courses.Include(x => x.Teacher).Where(t=> t.TeacherId == findEmail.Id).ToList();
            return null;
        }

        public ICollection<Exam> ViewExams(int id) => context.Exams.Where(x => x.CourseId == id).ToList();

        public ICollection<StudentExam> ViewResultOfExam(int id)
        {
            return context.StudentExams.Include(s=>s.Student).Where(x => x.ExamId == id).ToList();
        }
    }
}
