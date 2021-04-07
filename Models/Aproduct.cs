using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class Aproduct
    {
        public Aproduct()
        {
            PosorderDetails = new HashSet<PosorderDetail>();
            ProductPhysicalCounts = new HashSet<ProductPhysicalCount>();
            ProductWastages = new HashSet<ProductWastage>();
            SupplierOrderDetails = new HashSet<SupplierOrderDetail>();
        }

        public double ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }
        public int? SupplierTypeId { get; set; }
        public int? BasicUnitId { get; set; }
        public double? PackSize { get; set; }
        public int? ProductClassificationId { get; set; }
        public double? ListPrice { get; set; }
        public double? RetailPrice { get; set; }

        public virtual AbasicUnit BasicUnit { get; set; }
        public virtual AproductCategory Category { get; set; }
        public virtual AproductSupplier Supplier { get; set; }
        public virtual ICollection<PosorderDetail> PosorderDetails { get; set; }
        public virtual ICollection<ProductPhysicalCount> ProductPhysicalCounts { get; set; }
        public virtual ICollection<ProductWastage> ProductWastages { get; set; }
        public virtual ICollection<SupplierOrderDetail> SupplierOrderDetails { get; set; }
    }
}
