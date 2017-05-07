using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class Ppemaster
    {
        public Ppemaster()
        {
            Ppeconfiguration = new HashSet<Ppeconfiguration>();
        }

        public int PpemasterKey { get; set; }
        public string Label { get; set; }
        public string YesOrNo { get; set; }
        public string DefaultValue { get; set; }

        public virtual ICollection<Ppeconfiguration> Ppeconfiguration { get; set; }
    }
}
