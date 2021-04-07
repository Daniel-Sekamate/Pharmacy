using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class ProductPhysicalCount
    {
        public string PhysicalCountId { get; set; }
        public double ProductCode { get; set; }
        public DateTime PhysicalCountDate { get; set; }
        public string BatchNo { get; set; }
        public double? QuantityatPharmacy { get; set; }
        public double? QuantityatStore { get; set; }
        public double? Total { get; set; }
        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }

        public virtual Aproduct ProductCodeNavigation { get; set; }
    }
}
