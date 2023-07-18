using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class StudentPortal
    {
        public long StudentPortalId { get; set; }
        public long? StudentId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        public virtual Student? Student { get; set; }
    }
}
