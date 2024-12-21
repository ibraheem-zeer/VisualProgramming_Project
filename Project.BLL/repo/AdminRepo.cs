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
    public class AdminRepo : IAdmin
    {
        AppDbContext context = new AppDbContext();
        public string CreateCourse(Course course)
        {
            try
            {
                if (course != null)
                {
                    var test = context.Courses.Find(course.Id);
                    if(test == null) { 
                    context.Courses.Add(course);
                    context.SaveChanges();
                    return "sucess";
                    }else
                    return "course alerady created";

                }else
                return "Fill the Data";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string CreateExam(Exam exam)
        {
            try
            {
                if (exam != null)
                {
                    var test = context.Exams.Find(exam.Id);
                    if (test == null)
                    {
                        context.Exams.Add(exam);
                        context.SaveChanges();
                        return "sucess";
                    }
                    else
                        return "exam alerady created";

                }
                else
                    return "Fill the Data";
            }
            catch (Exception e)
            {
                return "Internal Server Error";
            }
        }

        public string CreateStudent(Student student)
        {
            try
            {
                if (student != null)
                {
                    var test = context.Students.Find(student.Id);
                    if (test == null)
                    {
                        context.Students.Add(student);
                        context.SaveChanges();
                        return "sucess";
                    }
                    else
                        return "student alerady created";

                }
                else
                    return "Fill the Data";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string CreateTeacher(Teacher teacher)
        {
            try
            {
                if (teacher != null)
                {
                    var test = context.Teachers.Find(teacher.Id);
                    if (test == null)
                    {
                        context.Teachers.Add(teacher);
                        context.SaveChanges();
                        return "sucess";
                    }
                    else
                        return "teacher alerady created";

                }
                else
                    return "Fill the Data";
            }
            catch (Exception e)
            {
                return "Internal Server Error";
            }
        }

        public string DeleteCourse(int id)
        {
            try
            {

                Course course = context.Courses.Find(id);

                if (course != null)
                {
                    context.Courses.Remove(course);
                    context.SaveChanges();
                    return "sucess";

                }
                else
                    return "Not Found";
            }
            catch (Exception e) {
                return "Internal Server Error";
            }
        }

        public string DeleteExam(int id)
        {
            try
            {
                Exam exam = context.Exams.Find(id);

                if (exam != null)
                {
                    context.Exams.Remove(exam);
                    context.SaveChanges();
                    return "sucess";

                }
                else
                    return "Not Found";
            }
            catch (Exception e)
            {
                return "Internal Server Error";
            }
        }

        public string DeleteStudent(int id)
        {
            try
            {
                Student student = context.Students.Find(id);

                if (student != null)
                {
                    context.Students.Remove(student);
                    context.SaveChanges();
                    return "sucess";
                }
                else return "Not Found";
            }
            catch (Exception e)
            {
                return "Internal Server Error";
            }
        }

        public string DeleteTeacher(int id)
        {
            try
            {
                Teacher teacher = context.Teachers.Find(id);
                if (teacher != null)
                {
                    context.Teachers.Remove(teacher);
                    context.SaveChanges();
                    return "sucess";
                }
                else return "Not Found";
            }
            catch (Exception e)
            {
                return "Internal Server Error";
            }
        }

        public ICollection<Course> GetAllCourses() => context.Courses.ToList();

        public ICollection<Exam> GetAllExams() => context.Exams.ToList();

        public ICollection<Student> GetAllStudents() => context.Students.ToList();

        public ICollection<Teacher> GetAllTeachers() => context.Teachers.ToList();

        public Course GetCourse(int id)
        {
            Course course = context.Courses.Find(id);
            if (course == null) return null;
            return course;
        }

        public Exam GetExam(int id)
        {
            Exam exam = context.Exams.Find(id);
            if (exam == null) return null;
            return exam;
        }

        public Student GetStudent(int id)
        {
            Student student = context.Students.Include(s=>s.Courses).ThenInclude(e=>e.Course).FirstOrDefault(s=>s.Id == id);
            if (student == null) return null;
            return student;
        }

        public Teacher GetTeacher(int id)
        {
            Teacher teacher = context.Teachers.Find(id);
            if (teacher == null) return null;
            return teacher;
        }

        public string UpdateCourse(Course course)
        {
            try
            {
                if (course != null)
                {
                    context.Update(course);
                    context.SaveChanges();
                    return "sucsses";
                }
                else
                    return "Course Not Found";
            }
            catch (Exception e) {
                return "Internal Server Error";
            }
        }

        public string UpdateExam(Exam exam)
        {
            try
            {
                if (exam != null)
                {
                    context.Update(exam);
                    context.SaveChanges();
                    return "sucsses";
                }
                else
                    return "Exam Not Found";
            }
            catch (Exception e)
            {
                return "Internal Server Error";
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
                else
                    return "Student Not Found";
            }
            catch (Exception e)
            {
                return "Internal Server Error";
            }
        }

        public string UpdateTeacher(Teacher teacher)
        {
            try
            {
                if (teacher != null)
                {
                    context.Update(teacher);
                    context.SaveChanges();
                    return "sucsses";
                }
                else
                    return "Teacher Not Found";
            }
            catch (Exception e)
            {
                return "Internal Server Error";
            }
        }

        public ICollection<StudentExam> ViewResult(int id)
        {
            return context.StudentExams.Include(s => s.Student).Where(x => x.ExamId == id).ToList();
        }
    }
}
