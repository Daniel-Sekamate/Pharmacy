using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class ViewAvailableBatch2
    {
        public string BatchId { get; set; }
        public double ProductCode { get; set; }
        public string BatchNo { get; set; }
        public double? RemainingBatchQuantity { get; set; }
        public DateTime? ExpiryDate { get; set; }
    }
}
