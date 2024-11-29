using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Specialization { get; set; } = null!;

        public ICollection<StudentCourse>? Courses { get; set; } = new HashSet<StudentCourse>();
        public ICollection<StudentExam>? Exams { get; set; } = new HashSet<StudentExam>();
    }
}
