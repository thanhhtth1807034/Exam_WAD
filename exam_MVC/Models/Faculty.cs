﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exam_MVC.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string NameFaculty { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}