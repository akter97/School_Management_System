using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class Branch
    {
        public Branch()
        {
            Campuses = new HashSet<Campus>();
        }

        public long BranchId { get; set; }
        public string? BranchLocation { get; set; }
        public string? BranchName { get; set; }

        public virtual ICollection<Campus> Campuses { get; set; }
    }
}
