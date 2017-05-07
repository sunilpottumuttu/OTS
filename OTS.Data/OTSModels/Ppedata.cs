using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class Ppedata
    {
        public long PpedataKey { get; set; }
        public long PpeconfigurationKey { get; set; }
        public int? ClientKey { get; set; }
        public string Value { get; set; }

        public virtual Ppeconfiguration PpeconfigurationKeyNavigation { get; set; }
    }
}
