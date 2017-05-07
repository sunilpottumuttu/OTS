using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class D30feedBack
    {
        public int TxnKey { get; set; }
        public DateTime? Date { get; set; }
        public int? DriverKey { get; set; }
        public string FeedBackStr { get; set; }
        public string ScreenName { get; set; }
        public string DocPath { get; set; }
        public DateTime? CrDt { get; set; }
        public DateTime? EdDt { get; set; }
        public int? CrBy { get; set; }
        public int? EdBy { get; set; }

        public virtual D10user DriverKeyNavigation { get; set; }
    }
}
