using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class ClientContact
    {
        public int ClientContactKey { get; set; }
        public int ClientKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; }

        public virtual Client ClientKeyNavigation { get; set; }
    }
}
