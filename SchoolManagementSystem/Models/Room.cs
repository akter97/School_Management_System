using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class Room
    {
        public Room()
        {
            ClassRoutines = new HashSet<ClassRoutine>();
        }

        public long RoomId { get; set; }
        public long? BuildingId { get; set; }
        public int? RoomNumber { get; set; }
        public int? Capacity { get; set; }

        public virtual Building? Building { get; set; }
        public virtual ICollection<ClassRoutine> ClassRoutines { get; set; }
    }
}
