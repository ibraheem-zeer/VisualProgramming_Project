using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Data.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime Date { get; set; } 
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int CourseId { get; set; }

        public Course Course { get; set; } = null!;
        public ICollection<StudentExam> Students { get; set; } = new HashSet<StudentExam>();
        public ICollection<Question>? Questions { get; set; } = new HashSet<Question>();
    }
}
