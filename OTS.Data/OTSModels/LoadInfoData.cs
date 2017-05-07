using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class LoadInfoData
    {
        public long LoadInfoDataKey { get; set; }
        public long LoadInfoConfigurationKey { get; set; }
        public int ClientKey { get; set; }
        public string Value { get; set; }

        public virtual LoadInfoConfiguration LoadInfoConfigurationKeyNavigation { get; set; }
    }
}
