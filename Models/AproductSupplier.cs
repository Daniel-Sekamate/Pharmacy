using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class AproductSupplier
    {
        public AproductSupplier()
        {
            Aproducts = new HashSet<Aproduct>();
            SupplierOrderHeaders = new HashSet<SupplierOrderHeader>();
        }

        public int SupplierId { get; set; }
        public string SupplierDescription { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Pobox { get; set; }
        public string Fax { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Aproduct> Aproducts { get; set; }
        public virtual ICollection<SupplierOrderHeader> SupplierOrderHeaders { get; set; }
    }
}
