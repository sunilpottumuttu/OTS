using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class VehicleTypeMaster
    {
        public VehicleTypeMaster()
        {
            ProductType = new HashSet<ProductType>();
        }

        public int VehicleTypeMasterKey { get; set; }
        public string Type { get; set; }

        public virtual ICollection<ProductType> ProductType { get; set; }
    }
}
