using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balimoon_E_Procurement.Models.BalimoonBML.ViewModel
{
    public class BMLUserVM
    {
        public AspNetUsers aspNetUsers { get; set; }
        public AspNetUserRoles aspNetUserRoles { get; set; }
        public AspNetRoles aspNetRoles { get; set; }
        public AspNetSystemUsers aspNetSystemUsers { get; set; }
        public DimensionValue dimensionValue { get; set; }
        public DimensionBuffer dimensionBuffer { get; set; }
        public Dimension dimension { get; set; }
        public Locations locations { get; set; }
    }
}
