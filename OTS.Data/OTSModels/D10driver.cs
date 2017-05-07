using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class D10driver
    {
        public int DriverKey { get; set; }
        public int ClientKey { get; set; }
        public int DispatcherKey { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Zone { get; set; }
        public string RegMobileNo { get; set; }
        public string Status { get; set; }
        public DateTime? CrDt { get; set; }
        public DateTime? EdDt { get; set; }
        public int? CrBy { get; set; }
        public int? EdBy { get; set; }

        public virtual D10client ClientKeyNavigation { get; set; }
        public virtual D10driver DriverKeyNavigation { get; set; }
        public virtual D10driver InverseDriverKeyNavigation { get; set; }
    }
}
