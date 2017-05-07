using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class D10location
    {
        public D10location()
        {
            D20ppedata = new HashSet<D20ppedata>();
            D30kxtxn = new HashSet<D30kxtxn>();
            D30loadInfoTxn = new HashSet<D30loadInfoTxn>();
            D30ppetxn = new HashSet<D30ppetxn>();
        }

        public int LocationKey { get; set; }
        public int ClientKey { get; set; }
        public int CustomerKey { get; set; }
        public string LocationId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string GpsId { get; set; }
        public DateTime? CrDt { get; set; }
        public DateTime? EdDt { get; set; }
        public int? CrBy { get; set; }
        public int? EdBy { get; set; }

        public virtual ICollection<D20ppedata> D20ppedata { get; set; }
        public virtual ICollection<D30kxtxn> D30kxtxn { get; set; }
        public virtual ICollection<D30loadInfoTxn> D30loadInfoTxn { get; set; }
        public virtual ICollection<D30ppetxn> D30ppetxn { get; set; }
        public virtual D10client ClientKeyNavigation { get; set; }
        public virtual D10customer CustomerKeyNavigation { get; set; }
    }
}
