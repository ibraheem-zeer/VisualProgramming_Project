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
    public class StudentRepo : IStudent
    {
        AppDbContext context = new AppDbContext();
        public ICollection<Question> DoExam(int id)
        {
            try
            {
                var exam = context.Exams.Include(q => q.Questions).First(e=> e.Id == id);
                if (exam == null) return null;
                DateTime currentDateTime = DateTime.Now;
                DateTime examStartDateTime = exam.Date.Add(exam.StartTime);
                DateTime examEndDateTime = exam.Date.Add(exam.EndTime);

                if (currentDateTime.Date == exam.Date && currentDateTime >= examStartDateTime && currentDateTime <= examEndDateTime)
                {
                    return exam.Questions;
                }
                return null;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public string Enroll(StudentCourse studentcourse)
        {
            try
            {
                if (studentcourse != null)
                {
                    context.StudentCourses.Remove(studentcourse);
                    context.SaveChanges();
                    return "sucess";
                }
                else
                    return "Fill the Data";
            }
            catch (Exception e)
            {
                return "Internal Server Error";
            }
        }

        public ICollection<Course> GetAllCourses() => context.Courses.ToList();

        public Course GetCourse(int id)
        {
            Course course = context.Courses.Find(id);
            if (course == null) return null;
            return course;
        }

        public Student Login(string Email, string Password)
        {
            try
            {
                Student student = context.Students.FirstOrDefault(s => s.Email == Email && s.Password == Password);
                if (student != null && student.Password == Password)
                {
                    return student;
                }
                else return null;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public string UpdateStudent(Student student)
        {
            try
            {
                if (student != null)
                {
                    context.Update(student);
                    context.SaveChanges();
                    return "sucsses";
                }
                else return "Student Not Found";
            }
            catch (Exception e)
            {
                return "Internal Server Error";
            }
        }
        public string SeeResult(int id)
        {

            try
            {
                var exam = context.Exams.Include(ex => ex.Students).FirstOrDefault(x=> x.Id == id);
                if (exam is null) return "-1";

                var res = exam.Students.Select(x => x.Result);
                foreach (var item in res) return item.ToString();
                return "-1";
            }
            catch
            {
                return "Internal Server Error";
            }
        }


        public ICollection<Exam> GetExams(int idCourse) => context.Exams.Include(s=>s.Students).Where(x=>x.CourseId == idCourse).ToList();

        public ICollection<Question> GetQuestion(int idExam) => context.Questions.Where(x => x.ExamId == idExam).ToList();

        public ICollection<StudentCourse> GetAllStudentCourses(int id) => context.StudentCourses.Where(c => c.StudentId == id).ToList();

        public ICollection<Course> GetAllAssignCourses(int id) => 
            context.Courses
                .Include(x => x.Students) 
                .Include(x => x.Teacher)  
                .Where(c => c.Students.Any(s => s.StudentId == id)) 
                .ToList();

        public string SaveResult(StudentExam studentExam)
        {
            try
            {
                context.StudentExams.Add(studentExam);
                context.SaveChanges();
                return "I wish you success";
            }
            catch (Exception ex) {
                return "somthing wrong";
            }
        } 
    }
}
