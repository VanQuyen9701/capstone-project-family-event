﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FamilyEventt.Models
{
    public partial class Voucher
    {
        public string VoucherId { get; set; }
        public string VoucherName { get; set; }
        public int VoucherDiscount { get; set; }
        public string VoucherImage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
        public string EventId { get; set; }

        public virtual Event Event { get; set; }
    }
}