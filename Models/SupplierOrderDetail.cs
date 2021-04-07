using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class SupplierOrderDetail
    {
        public SupplierOrderDetail()
        {
            SupplierOrderBatchDetails = new HashSet<SupplierOrderBatchDetail>();
        }

        public string ItemId { get; set; }
        public string OrderNumber { get; set; }
        public double ProductCode { get; set; }
        public double? RemainingStock { get; set; }
        public double? QuantityOrderd { get; set; }
        public double? QuantityRecieved { get; set; }
        public double? TotalQuantity { get; set; }
        public double? ListPrice { get; set; }
        public double? TotalPrice { get; set; }

        public virtual SupplierOrderHeader OrderNumberNavigation { get; set; }
        public virtual Aproduct ProductCodeNavigation { get; set; }
        public virtual ICollection<SupplierOrderBatchDetail> SupplierOrderBatchDetails { get; set; }
    }
}
