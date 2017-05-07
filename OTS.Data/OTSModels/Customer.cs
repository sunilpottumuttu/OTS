using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class Customer
    {
        public Customer()
        {
            Location = new HashSet<Location>();
        }

        public int CustomerKey { get; set; }
        public int ClientKey { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Location> Location { get; set; }
        public virtual Client ClientKeyNavigation { get; set; }
    }
}
