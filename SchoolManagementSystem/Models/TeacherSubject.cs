using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class TeacherSubject
    {
        public long TeacherSubjectId { get; set; }
        public long? SubjectId { get; set; }
        public long? TeacherId { get; set; }

        public virtual Subject? Subject { get; set; }
        public virtual Teacher? Teacher { get; set; }
    }
}
