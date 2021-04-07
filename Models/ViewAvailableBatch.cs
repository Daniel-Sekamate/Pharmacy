using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class ViewAvailableBatch
    {
        public string BatchId { get; set; }
        public double ProductCode { get; set; }
        public string BatchNo { get; set; }
        public double? RemainingBatchQuantity { get; set; }
    }
}
