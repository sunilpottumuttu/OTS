using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class LoadInfoConfiguration
    {
        public LoadInfoConfiguration()
        {
            LoadInfoData = new HashSet<LoadInfoData>();
        }

        public long LoadInfoConfigurationKey { get; set; }
        public long ProductTypeKey { get; set; }
        public long VehicleTypeKey { get; set; }
        public int LoadInfoMasterKey { get; set; }
        public int ClientKey { get; set; }

        public virtual ICollection<LoadInfoData> LoadInfoData { get; set; }
        public virtual LoadInfoMaster LoadInfoMasterKeyNavigation { get; set; }
        public virtual ProductType ProductTypeKeyNavigation { get; set; }
    }
}
