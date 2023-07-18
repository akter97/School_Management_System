using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class Session
    {
        public Session()
        {
            Students = new HashSet<Student>();
        }

        public long SessionId { get; set; }
        public string? SessionName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
