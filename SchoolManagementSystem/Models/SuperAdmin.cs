using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class SuperAdmin
    {
        public long SuperAdminId { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public string? Photo { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
