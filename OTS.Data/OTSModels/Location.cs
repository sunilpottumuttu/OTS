using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class Location
    {
        public Location()
        {
            Direction = new HashSet<Direction>();
            ProductType = new HashSet<ProductType>();
        }

        public long LocationKey { get; set; }
        public int CustomerKey { get; set; }
        public int ClientKey { get; set; }
        public string LocationId { get; set; }
        public string Name { get; set; }
        public string Gpsid { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Direction> Direction { get; set; }
        public virtual ICollection<ProductType> ProductType { get; set; }
        public virtual Client ClientKeyNavigation { get; set; }
        public virtual Customer CustomerKeyNavigation { get; set; }
    }
}
