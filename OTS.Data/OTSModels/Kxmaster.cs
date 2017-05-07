using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class Kxmaster
    {
        public long Kxkey { get; set; }
        public int ClientKey { get; set; }
        public int CustomerKey { get; set; }
        public long LocationKey { get; set; }
        public int? ProductTypeKey { get; set; }
        public int? VehicleTypeMasterKey { get; set; }
        public long? SubmissionKey { get; set; }
        public string Kxtype { get; set; }
        public string DocumentPath { get; set; }
        public string Tag1 { get; set; }
        public string Tag2 { get; set; }
        public string Tag3 { get; set; }
        public string Tag4 { get; set; }
        public string Tag5 { get; set; }
        public string Tag6 { get; set; }
        public string Status { get; set; }

        public virtual Client ClientKeyNavigation { get; set; }
        public virtual Submission SubmissionKeyNavigation { get; set; }
    }
}
