﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FamilyEventt.Models
{
    public partial class RoomLocation
    {
        public RoomLocation()
        {
            DateTimeLocation = new HashSet<DateTimeLocation>();
        }

        public string RoomId { get; set; }
        public string RoomName { get; set; }
        public string Parking { get; set; }
        public int Capacity { get; set; }
        public string RoomImage { get; set; }
        public string RoomDescription { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<DateTimeLocation> DateTimeLocation { get; set; }
    }
}