using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class AOrderStatus
    {
        public AOrderStatus()
        {
            PosOrdersHeaders = new HashSet<PosOrdersHeader>();
            SupplierOrderHeaders = new HashSet<SupplierOrderHeader>();
        }

        public int OrderStatus { get; set; }
        public string StatusDescription { get; set; }

        public virtual ICollection<PosOrdersHeader> PosOrdersHeaders { get; set; }
        public virtual ICollection<SupplierOrderHeader> SupplierOrderHeaders { get; set; }
    }
}
