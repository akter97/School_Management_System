using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class GradingSystem
    {
        public GradingSystem()
        {
            StudentResults = new HashSet<StudentResult>();
        }

        public long GradeId { get; set; }
        public long? Classid { get; set; }
        public string? GradeName { get; set; }
        public int? MaxMarks { get; set; }
        public int? MinimumMarks { get; set; }

        public virtual Class? Class { get; set; }
        public virtual ICollection<StudentResult> StudentResults { get; set; }
    }
}
