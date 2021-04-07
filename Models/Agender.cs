using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.Models
{
    public partial class Agender
    {
        public Agender()
        {
            AStaffs = new HashSet<AStaff>();
        }

        public int GenderId { get; set; }
        public string GenderName { get; set; }

        public virtual ICollection<AStaff> AStaffs { get; set; }
    }
}
