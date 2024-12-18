using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Data.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int? Level { get; set; }

        public int TeacherId { get; set; }

        public Teacher? Teacher { get; set; }
        public ICollection<Exam> Exams { get; set; }
        public ICollection<StudentCourse> Students { get; set; } = new HashSet<StudentCourse>();
    }
}
