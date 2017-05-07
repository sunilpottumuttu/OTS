using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class D10vehType
    {
        public D10vehType()
        {
            D20loadInfoData = new HashSet<D20loadInfoData>();
            D20ppedata = new HashSet<D20ppedata>();
            D30kxtxn = new HashSet<D30kxtxn>();
            D30loadInfoTxn = new HashSet<D30loadInfoTxn>();
            D30ppetxn = new HashSet<D30ppetxn>();
        }

        public int VehicleTypeKey { get; set; }
        public int ClientKey { get; set; }
        public string VehType { get; set; }
        public DateTime? CrDt { get; set; }
        public DateTime? EdDt { get; set; }
        public int? CrBy { get; set; }
        public int? EdBy { get; set; }

        public virtual ICollection<D20loadInfoData> D20loadInfoData { get; set; }
        public virtual ICollection<D20ppedata> D20ppedata { get; set; }
        public virtual ICollection<D30kxtxn> D30kxtxn { get; set; }
        public virtual ICollection<D30loadInfoTxn> D30loadInfoTxn { get; set; }
        public virtual ICollection<D30ppetxn> D30ppetxn { get; set; }
        public virtual D10client ClientKeyNavigation { get; set; }
    }
}
