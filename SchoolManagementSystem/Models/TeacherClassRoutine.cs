using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class TeacherClassRoutine
    {
        public long TeacherClassRoutineId { get; set; }
        public long? ClassRoutineId { get; set; }
        public long? TeacherId { get; set; }

        public virtual ClassRoutine? ClassRoutine { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}
