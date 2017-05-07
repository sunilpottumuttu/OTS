using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class Submission
    {
        public Submission()
        {
            Kxmaster = new HashSet<Kxmaster>();
            Reward = new HashSet<Reward>();
        }

        public long SubmissionKey { get; set; }
        public int ClientKey { get; set; }
        public int CustomerKey { get; set; }
        public long LocationKey { get; set; }
        public long DataKey { get; set; }
        public int UserKey { get; set; }
        public string Type { get; set; }
        public DateTime SubmittedDate { get; set; }
        public int? ReveiwedBy { get; set; }
        public DateTime? ReviewedDate { get; set; }
        public int? RewardPoints { get; set; }
        public string Comments { get; set; }
        public string Status { get; set; }
        public string DocumentPath { get; set; }

        public virtual ICollection<Kxmaster> Kxmaster { get; set; }
        public virtual ICollection<Reward> Reward { get; set; }
        public virtual Client ClientKeyNavigation { get; set; }
        public virtual User UserKeyNavigation { get; set; }
    }
}
