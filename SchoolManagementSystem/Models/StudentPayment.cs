using System;
using System.Collections.Generic;

namespace SchoolManagementSystem.Models
{
    public partial class StudentPayment
    {
        public long StudentPaymentId { get; set; }
        public long? StudentId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? PaymentAmmount { get; set; }
        public string? PaymentType { get; set; }
        public string? PaymentReference { get; set; }
        public string? PaymentStatus { get; set; }

        public virtual Student? Student { get; set; }
    }
}
