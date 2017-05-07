using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class D20loadInfoData
    {
        public D20loadInfoData()
        {
            D30loadInfoTxn = new HashSet<D30loadInfoTxn>();
        }

        public int LoadInfoKey { get; set; }
        public int ClientKey { get; set; }
        public int CustomerKey { get; set; }
        public int LocationKey { get; set; }
        public int ProdTypeKey { get; set; }
        public int VehTypeKey { get; set; }
        public string Value { get; set; }
        public string Remark { get; set; }
        public DateTime? CrDt { get; set; }
        public DateTime? EdDt { get; set; }
        public int? CrBy { get; set; }
        public int? EdBy { get; set; }

        public virtual ICollection<D30loadInfoTxn> D30loadInfoTxn { get; set; }
        public virtual D10client ClientKeyNavigation { get; set; }
        public virtual D10customer CustomerKeyNavigation { get; set; }
        public virtual D10loadInfo LoadInfoKeyNavigation { get; set; }
        public virtual D10prodType ProdTypeKeyNavigation { get; set; }
        public virtual D10vehType VehTypeKeyNavigation { get; set; }
    }
}
