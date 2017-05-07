using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class D30kxtxn
    {
        public int TxnKey { get; set; }
        public DateTime? Date { get; set; }
        public int? ClientKey { get; set; }
        public int? DriverKey { get; set; }
        public int? CustomerKey { get; set; }
        public int? LocationKey { get; set; }
        public int? ProdTypeKey { get; set; }
        public int? VehTypeKey { get; set; }
        public string Name { get; set; }
        public string Kxtype { get; set; }
        public string DocPath { get; set; }
        public string Tag1 { get; set; }
        public string Tag2 { get; set; }
        public string Tag3 { get; set; }
        public string Tag4 { get; set; }
        public string Tag5 { get; set; }
        public string Tag6 { get; set; }
        public string Status { get; set; }
        public int? RewardPoint { get; set; }
        public int? UserKey { get; set; }
        public DateTime? CrDt { get; set; }
        public DateTime? EdDt { get; set; }
        public int? CrBy { get; set; }
        public int? EdBy { get; set; }

        public virtual D10client ClientKeyNavigation { get; set; }
        public virtual D10customer CustomerKeyNavigation { get; set; }
        public virtual D10user DriverKeyNavigation { get; set; }
        public virtual D10location LocationKeyNavigation { get; set; }
        public virtual D10prodType ProdTypeKeyNavigation { get; set; }
        public virtual D10vehType VehTypeKeyNavigation { get; set; }
    }
}
