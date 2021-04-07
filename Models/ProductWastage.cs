using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class ProductWastage
    {
        public string WastageId { get; set; }
        public DateTime WastageDate { get; set; }
        public double ProductCode { get; set; }
        public int? BasicUnitId { get; set; }
        public string BatchNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public double? Quantity { get; set; }
        public string WastageReason { get; set; }
        public string WastedBy { get; set; }

        public virtual AbasicUnit BasicUnit { get; set; }
        public virtual Aproduct ProductCodeNavigation { get; set; }
        public virtual AStaff WastedByNavigation { get; set; }
    }
}
