using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class ViewPosOrder
    {
        public string ItemId { get; set; }
        public string SaleId { get; set; }
        public int? OrderStatusId { get; set; }
        public DateTime? OrderDate { get; set; }
        public double ProductCode { get; set; }
        public int? BasicUnitId { get; set; }
        public string BatchNo { get; set; }
        public double? Quantity { get; set; }
        public double? SellPrice { get; set; }
        public double? TotalPrice { get; set; }
        public string Buyer { get; set; }
    }
}
