using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class D10docType
    {
        public D10docType()
        {
            D30docScanTxn = new HashSet<D30docScanTxn>();
        }

        public int DocTypeKey { get; set; }
        public int? ClientKey { get; set; }
        public string DocType { get; set; }
        public string ShortStr { get; set; }
        public DateTime? CrDt { get; set; }
        public DateTime? EdDt { get; set; }
        public int? CrBy { get; set; }
        public int? EdBy { get; set; }

        public virtual ICollection<D30docScanTxn> D30docScanTxn { get; set; }
    }
}
