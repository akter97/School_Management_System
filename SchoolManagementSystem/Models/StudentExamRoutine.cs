using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class StudentExamRoutine
    {
        public long StudentExamRoutineId { get; set; }
        public long? ExamId { get; set; }
        public long? StudentId { get; set; }

        public virtual Exam? Exam { get; set; }
        public virtual Student? Student { get; set; }
    }
}
