using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class AbasicUnit
    {
        public AbasicUnit()
        {
            Aproducts = new HashSet<Aproduct>();
            PosorderDetails = new HashSet<PosorderDetail>();
            ProductWastages = new HashSet<ProductWastage>();
        }

        public int BasicUnitId { get; set; }
        public string BasicUnitDescription { get; set; }

        public virtual ICollection<Aproduct> Aproducts { get; set; }
        public virtual ICollection<PosorderDetail> PosorderDetails { get; set; }
        public virtual ICollection<ProductWastage> ProductWastages { get; set; }
    }
}
