using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class ViewSystemRemainingStock
    {
        public string BatchId { get; set; }
        public int? SupplierId { get; set; }
        public DateTime? StockDate { get; set; }
        public int? OrderStatus { get; set; }
        public double ProductCode { get; set; }
        public string BatchNo { get; set; }
        public int? PurchaseBasicUnitId { get; set; }
        public double? TotalQuantity { get; set; }
        public double? PurchasedBatchQuantity { get; set; }
        public double? SoldBatchQuantity { get; set; }
        public double? RemainingBatchQuantity { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
