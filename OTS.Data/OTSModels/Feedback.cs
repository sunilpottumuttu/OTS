using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class Feedback
    {
        public long FeedbackKey { get; set; }
        public int ClientKey { get; set; }
        public int UserKey { get; set; }
        public string ScreenName { get; set; }
        public string Comment { get; set; }
        public string DocumentPath { get; set; }
        public string Response { get; set; }
        public DateTime? ResponseDate { get; set; }

        public virtual Client ClientKeyNavigation { get; set; }
        public virtual User UserKeyNavigation { get; set; }
    }
}
