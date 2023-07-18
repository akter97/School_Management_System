using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class StudentClassRoutine
    {
        public long StudentClassRoutineId { get; set; }
        public long? ClassRoutineId { get; set; }
        public long? StudentId { get; set; }

        public virtual ClassRoutine? ClassRoutine { get; set; }
        public virtual Student? Student { get; set; }
    }
}
