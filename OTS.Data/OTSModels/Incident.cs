using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class Incident
    {
        public int IncidentKey { get; set; }
        public int ClientKey { get; set; }
        public int UserKey { get; set; }
        public string Gpslocation { get; set; }
        public string Status { get; set; }
        public string DocumentPath { get; set; }

        public virtual Client ClientKeyNavigation { get; set; }
        public virtual User UserKeyNavigation { get; set; }
    }
}
