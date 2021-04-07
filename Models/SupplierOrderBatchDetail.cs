using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class SupplierOrderBatchDetail
    {
        public string BatchId { get; set; }
        public string ItemId { get; set; }
        public string BatchNo { get; set; }
        public double? Quantity { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public virtual SupplierOrderDetail Item { get; set; }
    }
}
