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

        string CreateStudent(Student student);
        string UpdateStudent(Student student);
        string DeleteStudent(int id);
        string CreateTeacher(Teacher teacher);
        string UpdateTeacher(Teacher teacher);
        string DeleteTeacher(int id);
        string CreateCourse(Course course);
        string UpdateCourse(Course course);
        string DeleteCourse(int id);
        string CreateExam(Exam exam);
        string UpdateExam(Exam exam);
        string DeleteExam(int id);
        ICollection<StudentExam> ViewResult(int id);
    }
}
