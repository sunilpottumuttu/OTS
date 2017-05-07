using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class Direction
    {
        public long DirectionKey { get; set; }
        public long LocationKey { get; set; }
        public int ClientKey { get; set; }
        public string Direction1 { get; set; }
        public string Direction2 { get; set; }

        public virtual Location LocationKeyNavigation { get; set; }
    }
}
