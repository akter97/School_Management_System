using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class Designation
    {
        public Designation()
        {
            TeacherDesignations = new HashSet<TeacherDesignation>();
        }

        public long DesignationId { get; set; }
        public string? DesignationName { get; set; }

        public virtual ICollection<TeacherDesignation> TeacherDesignations { get; set; }
    }
}
