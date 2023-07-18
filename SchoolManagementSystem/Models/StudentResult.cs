using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class StudentResult
    {
        public long StudentResultId { get; set; }
        public long? StudentId { get; set; }
        public long? SubjectId { get; set; }
        public long? GradeId { get; set; }
        public decimal? ObtainedMark { get; set; }

        public virtual GradingSystem? Grade { get; set; }
        public virtual Student? Student { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}
