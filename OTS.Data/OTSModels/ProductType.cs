using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class ProductType
    {
        public ProductType()
        {
            LoadInfoConfiguration = new HashSet<LoadInfoConfiguration>();
            Ppeconfiguration = new HashSet<Ppeconfiguration>();
        }

        public long ProductTypeKey { get; set; }
        public long LocationKey { get; set; }
        public int VehicleTypeMasterKey { get; set; }
        public int ClientKey { get; set; }
        public string Type { get; set; }

        public virtual ICollection<LoadInfoConfiguration> LoadInfoConfiguration { get; set; }
        public virtual ICollection<Ppeconfiguration> Ppeconfiguration { get; set; }
        public virtual Location LocationKeyNavigation { get; set; }
        public virtual VehicleTypeMaster VehicleTypeMasterKeyNavigation { get; set; }
    }
}
