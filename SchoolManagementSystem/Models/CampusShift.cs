using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class CampusShift
    {
        public long CampusShiftId { get; set; }
        public long? ShiftId { get; set; }
        public Guid? CampusId { get; set; }

        public virtual Campus? Campus { get; set; }
        public virtual Shift? Shift { get; set; }
    }
}
