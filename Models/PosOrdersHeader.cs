using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class PosOrdersHeader
    {
        public PosOrdersHeader()
        {
            PosorderDetails = new HashSet<PosorderDetail>();
        }

        public string SaleId { get; set; }
        public string Buyer { get; set; }
        public int? OrderStatusId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string CreatedBy { get; set; }
        public string CancelledBy { get; set; }
        public double? TotalCost { get; set; }
        public double? AmountPaid { get; set; }
        public double? Balance { get; set; }

        public virtual AOrderStatus OrderStatus { get; set; }
        public virtual ICollection<PosorderDetail> PosorderDetails { get; set; }
    }
}
