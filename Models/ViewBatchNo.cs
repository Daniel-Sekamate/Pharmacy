using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class ViewBatchNo
    {
        public long? Id { get; set; }
        public string BatchNo { get; set; }
        public double ProductCode { get; set; }
        public string ProductDescription { get; set; }
    }
}
