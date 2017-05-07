using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class DocumentMaster
    {
        public DocumentMaster()
        {
            DocumentSubmission = new HashSet<DocumentSubmission>();
        }

        public long DocumentMasterKey { get; set; }
        public int ClientKey { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public virtual ICollection<DocumentSubmission> DocumentSubmission { get; set; }
        public virtual Client ClientKeyNavigation { get; set; }
    }
}
