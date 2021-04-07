using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class ViewMostCurrentSupply
    {
        public string BatchId { get; set; }
        public string OrderNumber { get; set; }
        public int? SupplierId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? OrderStatus { get; set; }
        public double ProductCode { get; set; }
        public double? TotalQuantity { get; set; }
        public string BatchNo { get; set; }
        public double? Quantity { get; set; }
        public int? BasicUnitId { get; set; }
        public double? PackSize { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
