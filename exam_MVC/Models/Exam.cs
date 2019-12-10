using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace exam_MVC.Models
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        
        public int FacultyId { get; set; }
        public int ExamSubjectId { get; set; }
        public int ClassRoomId { get; set; }
        
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime StarTime{ get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ExamDate{ get; set; }
        [Required]
        public int ExamDuration { get; set; }
        
        public ExamStatus Status { get; set; }
        
        public virtual Faculty Faculty { get; set; }
        public virtual ExamSubject ExamSubject { get; set; }
        public virtual ClassRoom ClassRoom { get; set; }

    }

    public enum ExamStatus
    {
        UpComing = 1, OnGoing = 2, Done = 3
    }

    
}