using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class D30redeemTxn
    {
        public int TxnKey { get; set; }
        public DateTime? Date { get; set; }
        public int? ClientKey { get; set; }
        public int? DriverKey { get; set; }
        public string Description { get; set; }
        public int? RedeemPoints { get; set; }
        public string Status { get; set; }
        public int? UserKey { get; set; }
        public DateTime? CrDt { get; set; }
        public DateTime? EdDt { get; set; }
        public int? CrBy { get; set; }
        public int? EdBy { get; set; }

        public virtual D10client ClientKeyNavigation { get; set; }
        public virtual D10user DriverKeyNavigation { get; set; }
        public virtual D10user UserKeyNavigation { get; set; }
    }
}
