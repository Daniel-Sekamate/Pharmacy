using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class ViewAvailableProduct
    {
        public double ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryDescription { get; set; }
        public int? ProductClassificationId { get; set; }
        public string ClassificationDesc { get; set; }
        public int? BasicUnitId { get; set; }
        public string BasicUnitDescription { get; set; }
        public double? PackSize { get; set; }
        public int? SupplierId { get; set; }
        public string SupplierDescription { get; set; }
        public double? ListPrice { get; set; }
    }
}
