using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class D10client
    {
        public D10client()
        {
            D10customer = new HashSet<D10customer>();
            D10driver = new HashSet<D10driver>();
            D10loadInfo = new HashSet<D10loadInfo>();
            D10location = new HashSet<D10location>();
            D10ppe = new HashSet<D10ppe>();
            D10vehType = new HashSet<D10vehType>();
            D20loadInfoData = new HashSet<D20loadInfoData>();
            D20ppedata = new HashSet<D20ppedata>();
            D30docScanTxn = new HashSet<D30docScanTxn>();
            D30incidenceTxn = new HashSet<D30incidenceTxn>();
            D30kxtxn = new HashSet<D30kxtxn>();
            D30loadInfoTxn = new HashSet<D30loadInfoTxn>();
            D30ppetxn = new HashSet<D30ppetxn>();
            D30redeemTxn = new HashSet<D30redeemTxn>();
        }

        public int ClientKey { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string DocumentPath { get; set; }
        public string Status { get; set; }
        public DateTime? CrDt { get; set; }
        public DateTime? EdDt { get; set; }
        public int? CrBy { get; set; }
        public int? EdBy { get; set; }

        public virtual ICollection<D10customer> D10customer { get; set; }
        public virtual ICollection<D10driver> D10driver { get; set; }
        public virtual ICollection<D10loadInfo> D10loadInfo { get; set; }
        public virtual ICollection<D10location> D10location { get; set; }
        public virtual ICollection<D10ppe> D10ppe { get; set; }
        public virtual ICollection<D10vehType> D10vehType { get; set; }
        public virtual ICollection<D20loadInfoData> D20loadInfoData { get; set; }
        public virtual ICollection<D20ppedata> D20ppedata { get; set; }
        public virtual ICollection<D30docScanTxn> D30docScanTxn { get; set; }
        public virtual ICollection<D30incidenceTxn> D30incidenceTxn { get; set; }
        public virtual ICollection<D30kxtxn> D30kxtxn { get; set; }
        public virtual ICollection<D30loadInfoTxn> D30loadInfoTxn { get; set; }
        public virtual ICollection<D30ppetxn> D30ppetxn { get; set; }
        public virtual ICollection<D30redeemTxn> D30redeemTxn { get; set; }
    }
}
