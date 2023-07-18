using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class Building
    {
        public Building()
        {
            Rooms = new HashSet<Room>();
        }

        public long BuildingId { get; set; }
        public Guid? CampusId { get; set; }
        public string? BuildingName { get; set; }

        public virtual Campus? Campus { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
