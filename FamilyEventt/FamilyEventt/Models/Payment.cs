﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FamilyEventt.Models
{
    public partial class Payment
    {
        public string PaymentId { get; set; }
        public string EventId { get; set; }
        public decimal Amount { get; set; }
        public string PayContent { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

        public virtual Event Event { get; set; }
    }
}