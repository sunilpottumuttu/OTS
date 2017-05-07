using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class DocumentSubmission
    {
        public long DocumentSubmissionKey { get; set; }
        public int ClientKey { get; set; }
        public long DocumentMasterKey { get; set; }
        public int UserKey { get; set; }
        public string Comment { get; set; }
        public string DocumentPath { get; set; }
        public int? ReviewedBy { get; set; }
        public DateTime? ReviewDate { get; set; }
        public string Status { get; set; }

        public virtual Client ClientKeyNavigation { get; set; }
        public virtual DocumentMaster DocumentMasterKeyNavigation { get; set; }
        public virtual User UserKeyNavigation { get; set; }
    }
}
