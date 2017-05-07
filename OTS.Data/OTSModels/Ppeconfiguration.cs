using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class Ppeconfiguration
    {
        public Ppeconfiguration()
        {
            Ppedata = new HashSet<Ppedata>();
        }

        public long PpeconfigurationKey { get; set; }
        public long ProductTypeKey { get; set; }
        public long VehicleTypeKey { get; set; }
        public int PpemasterKey { get; set; }
        public int ClientKey { get; set; }

        public virtual ICollection<Ppedata> Ppedata { get; set; }
        public virtual Ppemaster PpemasterKeyNavigation { get; set; }
        public virtual ProductType ProductTypeKeyNavigation { get; set; }
    }
}
