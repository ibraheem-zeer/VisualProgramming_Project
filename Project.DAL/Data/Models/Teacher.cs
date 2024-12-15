using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Data.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [EmailAddress]
        public string Email { get; set; } = null!;
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        public string collage { get; set; } = null!;

        public int CourseId { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
