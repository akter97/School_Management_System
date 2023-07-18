using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class StudentPromotion
    {
        public long StudentPromotionId { get; set; }
        public long? StudentId { get; set; }
        public long? ClassId { get; set; }
        public DateTime? PromotionDate { get; set; }
        public bool? PromotionStatus { get; set; }
        public string? PromotionReason { get; set; }
        public string? PromotionApprover { get; set; }

        public virtual Class? Class { get; set; }
        public virtual Student? Student { get; set; }
    }
}
