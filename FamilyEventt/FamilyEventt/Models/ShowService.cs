﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FamilyEventt.Models
{
    public partial class ShowService
    {
        public ShowService()
        {
            EntertainmentProduct = new HashSet<EntertainmentProduct>();
        }

        public string ShowId { get; set; }
        public decimal ShowPrice { get; set; }
        public string ShowServiceName { get; set; }
        public string Light { get; set; }
        public string Sound { get; set; }
        public string Singer { get; set; }
        public string ShowDescription { get; set; }
        public string ShowImage { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<EntertainmentProduct> EntertainmentProduct { get; set; }
    }
}