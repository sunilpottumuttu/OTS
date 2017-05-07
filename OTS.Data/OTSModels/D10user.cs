using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class D10user
    {
        public D10user()
        {
            D30docScanTxn = new HashSet<D30docScanTxn>();
            D30feedBack = new HashSet<D30feedBack>();
            D30kxtxn = new HashSet<D30kxtxn>();
            D30loadInfoTxn = new HashSet<D30loadInfoTxn>();
            D30ppetxn = new HashSet<D30ppetxn>();
            D30redeemTxnDriverKeyNavigation = new HashSet<D30redeemTxn>();
            D30redeemTxnUserKeyNavigation = new HashSet<D30redeemTxn>();
        }

        public int UserKey { get; set; }
        public int ClientKey { get; set; }
        public int? ManagerKey { get; set; }
        public string Name { get; set; }
        public string Roll { get; set; }
        public string Email { get; set; }
        public string RegMobileNo { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public DateTime? CrDt { get; set; }
        public DateTime? EdDt { get; set; }
        public int? CrBy { get; set; }
        public int? EdBy { get; set; }

        public virtual ICollection<D30docScanTxn> D30docScanTxn { get; set; }
        public virtual ICollection<D30feedBack> D30feedBack { get; set; }
        public virtual ICollection<D30kxtxn> D30kxtxn { get; set; }
        public virtual ICollection<D30loadInfoTxn> D30loadInfoTxn { get; set; }
        public virtual ICollection<D30ppetxn> D30ppetxn { get; set; }
        public virtual ICollection<D30redeemTxn> D30redeemTxnDriverKeyNavigation { get; set; }
        public virtual ICollection<D30redeemTxn> D30redeemTxnUserKeyNavigation { get; set; }
        public virtual D10user ManagerKeyNavigation { get; set; }
        public virtual ICollection<D10user> InverseManagerKeyNavigation { get; set; }
    }
}
