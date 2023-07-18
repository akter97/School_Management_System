using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class Stuff
    {
        public long StuffId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Qualification { get; set; }
        public string? Religion { get; set; }
        public string? AssignedTo { get; set; }
    }
}
