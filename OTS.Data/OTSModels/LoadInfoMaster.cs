using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class LoadInfoMaster
    {
        public LoadInfoMaster()
        {
            LoadInfoConfiguration = new HashSet<LoadInfoConfiguration>();
        }

        public int LoadInfoMasterKey { get; set; }
        public string Label { get; set; }
        public string YesOrNo { get; set; }
        public string DefaultValue { get; set; }

        public virtual ICollection<LoadInfoConfiguration> LoadInfoConfiguration { get; set; }
    }
}
