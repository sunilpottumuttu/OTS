using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class Reward
    {
        public long RewardKey { get; set; }
        public int? ClientKey { get; set; }
        public int? UserKey { get; set; }
        public long? SubmissionKey { get; set; }
        public int? RewardPoints { get; set; }
        public int? BalancePoints { get; set; }
        public string RedeemStatus { get; set; }
        public string Comment { get; set; }

        public virtual Client ClientKeyNavigation { get; set; }
        public virtual Submission SubmissionKeyNavigation { get; set; }
        public virtual User UserKeyNavigation { get; set; }
    }
}
