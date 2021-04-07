using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class ViewPhysicalCount
    {
        public DateTime PhysicalCountDate { get; set; }
        public double ProductCode { get; set; }
        public double? ClosingBalance { get; set; }
    }
}
