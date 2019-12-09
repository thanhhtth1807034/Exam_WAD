using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace exam_MVC.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class MyDBContext : DbContext
    {
        public MyDBContext() : base("name=MyContext")
        {

        }
        public DbSet<Exam> Exams { get; set; }

        public System.Data.Entity.DbSet<exam_MVC.Models.ExamSubject> ExamSubjects { get; set; }
        public System.Data.Entity.DbSet<exam_MVC.Models.Faculty> Faculties { get; set; }
        public System.Data.Entity.DbSet<exam_MVC.Models.ClassRoom> ClassRooms { get; set; }
    }
}