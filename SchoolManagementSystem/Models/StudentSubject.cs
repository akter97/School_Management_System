using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class StudentSubject
    {
        public long StudentSubjectId { get; set; }
        public long? SubjectId { get; set; }
        public long? StudentId { get; set; }

        public virtual Student? Student { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}
