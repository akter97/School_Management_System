using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class CampusCurriculum
    {
        public long CampusCurriculumId { get; set; }
        public long? CurriculumId { get; set; }
        public Guid? CampusId { get; set; }

        public virtual Campus? Campus { get; set; }
        public virtual Curriculum? Curriculum { get; set; }
    }
}
