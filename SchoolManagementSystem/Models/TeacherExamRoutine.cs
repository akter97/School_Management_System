using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class TeacherExamRoutine
    {
        public long TeacherExamRoutineId { get; set; }
        public long? ExamId { get; set; }
        public long? TeacherId { get; set; }

        public virtual Exam? Exam { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}
