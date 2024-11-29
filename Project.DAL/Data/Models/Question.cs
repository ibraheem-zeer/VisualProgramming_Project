using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Data.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Choice1 { get; set; } = null!;
        public string Choice2 { get; set; } = null!;
        public string? Choice3 { get; set; }
        public string? Choice4 { get; set; }
        public string Answer { get; set; } = null!;

        public int ExamId { get; set; }
        public Exam Exam { get; set; } = null!;
    }
}
