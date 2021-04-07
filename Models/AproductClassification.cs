using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class AproductClassification
    {
        public int ClassificationId { get; set; }
        public int? ProductCategoryId { get; set; }
        public string ClassificationDesc { get; set; }

        public virtual AproductCategory ProductCategory { get; set; }
    }
}
