﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Data.Models
{
    public class StudentExam
    {
        public double Result { get; set; }

        public int StudentId { get; set; }
        public int ExamId { get; set; }

        public Student Student { get; set; }
        public Exam Exam { get; set; }
    }
}
