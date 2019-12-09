using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exam_MVC.Models
{
    public class ExamSubject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}