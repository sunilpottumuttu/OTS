using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class Role
    {
        public Role()
        {
            UserRole = new HashSet<UserRole>();
        }

        public int RoleKey { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
