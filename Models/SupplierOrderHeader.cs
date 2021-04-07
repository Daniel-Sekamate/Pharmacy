using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class SupplierOrderHeader
    {
        public SupplierOrderHeader()
        {
            SupplierOrderDetails = new HashSet<SupplierOrderDetail>();
        }

        public string OrderNumber { get; set; }
        public int? SupplierId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? OrderStatus { get; set; }
        public string OrderCreatedBy { get; set; }
        public string OrderConfirmedBy { get; set; }
        public DateTime? DateConfirmed { get; set; }
        public string StockRecievedBy { get; set; }
        public DateTime? DateReceived { get; set; }
        public string StockComfirmedBy { get; set; }
        public DateTime? StockConfirmationDate { get; set; }

        public virtual AOrderStatus OrderStatusNavigation { get; set; }
        public virtual AproductSupplier Supplier { get; set; }
        public virtual ICollection<SupplierOrderDetail> SupplierOrderDetails { get; set; }
    }
}
