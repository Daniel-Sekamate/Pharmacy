using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class AproductCategory
    {
        public AproductCategory()
        {
            AproductClassifications = new HashSet<AproductClassification>();
            Aproducts = new HashSet<Aproduct>();
        }

        public int CategoryId { get; set; }
        public string CategoryDescription { get; set; }

        public virtual ICollection<AproductClassification> AproductClassifications { get; set; }
        public virtual ICollection<Aproduct> Aproducts { get; set; }
    }
}
