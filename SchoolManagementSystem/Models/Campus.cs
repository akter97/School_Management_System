using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class Campus
    {
        public Campus()
        {
            Buildings = new HashSet<Building>();
            CampusCurricula = new HashSet<CampusCurriculum>();
            CampusShifts = new HashSet<CampusShift>();
            Students = new HashSet<Student>();
        }

        public Guid CampusId { get; set; }
        public long? BranchId { get; set; }
        public string? CampusName { get; set; }
        public string? Location { get; set; }

        public virtual Branch? Branch { get; set; }
        public virtual ICollection<Building> Buildings { get; set; }
        public virtual ICollection<CampusCurriculum> CampusCurricula { get; set; }
        public virtual ICollection<CampusShift> CampusShifts { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
