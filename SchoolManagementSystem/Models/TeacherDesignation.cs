using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class TeacherDesignation
    {
        public long TeacherDesignationId { get; set; }
        public long? DesignationId { get; set; }
        public long? TeacherId { get; set; }

        public virtual Designation? Designation { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}
