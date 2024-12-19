﻿using Microsoft.EntityFrameworkCore;
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

        public string DoExam(int id)
        {
            throw new NotImplementedException();
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

        public ICollection<Course> GetAllCourses()
        {
            return context.Courses.ToList();
        }

        public Course GetCourse(int id)
        {
            Course course = context.Courses.Find(id);
            if (course == null)
                return null;

            return course;
        }

        public Student Login(string Email, string Password)
        {
            try
            {
                Student student = context.Students
                    .FirstOrDefault(s => s.Email == Email && s.Password == Password);

                if (student != null && student.Password == Password)
                {
                    return student;
                }
                else
                    return null;
                
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
                else
                    return "Student Not Found";

            }
            catch (Exception e)
            {
                return "Internal Server Error";
            }
        }
        public string SeeResult(int id)
        {
            throw new NotImplementedException();
        }


        public ICollection<Exam> GetExams(int idCourse)
        {
            return context.Exams.Where(x=>x.CourseId == idCourse).ToList();
        }

        public ICollection<Question> GetQuestion(int idExam)
        {
            return context.Questions.Where(x => x.ExamId == idExam).ToList();
        }

        public ICollection<StudentCourse> GetAllStudentCourses(int id)
        {
            return context.StudentCourses.Where(c => c.StudentId == id).ToList();
        }

        public ICollection<Course> GetAllAssignCourses(int id)
        {
            return context.Courses
                .Include(x => x.Students) 
                .Include(x => x.Teacher)  
                .Where(c => c.Students.Any(s => s.StudentId == id)) 
                .ToList();
        }
    }
}