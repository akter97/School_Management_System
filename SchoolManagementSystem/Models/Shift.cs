using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class Shift
    {
        public Shift()
        {
            CampusShifts = new HashSet<CampusShift>();
            ClassRoutines = new HashSet<ClassRoutine>();
            Students = new HashSet<Student>();
        }

        public long ShiftId { get; set; }
        public string? ShiftName { get; set; }
        public string? ShiftType { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }

        public virtual ICollection<CampusShift> CampusShifts { get; set; }
        public virtual ICollection<ClassRoutine> ClassRoutines { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
