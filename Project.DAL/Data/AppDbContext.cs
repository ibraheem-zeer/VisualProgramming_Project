using Microsoft.EntityFrameworkCore;
using Project.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Data
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS01;Database=VP_Project;Trusted_Connection=True;TrustServerCertificate=True");
        }

        DbSet<Teacher> Teacher { get; set; }
        DbSet<Student> Student { get; set; }
        DbSet<Course> Course { get; set; }
        DbSet<Exam> Exam { get; set; }
        DbSet<Question> Question { get; set; }
        DbSet<StudentCourse> StudentCourse { get; set; }
        DbSet<StudentExam> StudentExam { get; set; }
    }
}
