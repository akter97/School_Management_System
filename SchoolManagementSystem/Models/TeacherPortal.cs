using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class TeacherPortal
    {
        public long TeacherPortalId { get; set; }
        public long? TeacherId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        public virtual Teacher? Teacher { get; set; }
    }
}
