using Project.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Interfaces
{
    public interface IAdmin
    {
        ICollection<Student> GetAllStudents();
        ICollection<Teacher> GetAllTeachers();
        ICollection<Course> GetAllCourses();
        ICollection<Exam> GetAllExams();

        Student GetStudent(int id);
        Teacher GetTeacher(int id);
        Course GetCourse(int id);
        Exam GetExam(int id);

        int CreateStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(Student student);
        int CreateTeacher(Teacher teacher);
        int UpdateTeacher(Teacher teacher);
        int DeleteTeacher(Teacher teacher);
        int CreateCourse(Course course);
        int UpdateCourse(Course course);
        int DeleteCourse(Course course);
        int CreateExam(Exam exam);
        int UpdateExam(Exam exam);
        int DeleteExam(Exam exam);
        int ViewResult();
    }
}
