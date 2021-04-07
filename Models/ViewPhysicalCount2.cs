using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class ViewPhysicalCount2
    {
        public DateTime PhysicalCountDate { get; set; }
        public double ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int? SupplierId { get; set; }
        public double? ClosingBalance { get; set; }
    }
}
