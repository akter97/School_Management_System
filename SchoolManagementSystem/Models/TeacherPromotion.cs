using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class TeacherPromotion
    {
        public long TeacherPromotionId { get; set; }
        public long? TeacherId { get; set; }
        public DateTime? PromotionDate { get; set; }
        public bool? PromotionStatus { get; set; }
        public string? PromotionReason { get; set; }
        public string? PromotionApprover { get; set; }

        public virtual Teacher? Teacher { get; set; }
    }
}
