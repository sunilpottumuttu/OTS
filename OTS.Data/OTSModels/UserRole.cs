using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class UserRole
    {
        public int UserRoleKey { get; set; }
        public int ClientKey { get; set; }
        public int UserKey { get; set; }
        public int RoleKey { get; set; }
        public string Status { get; set; }

        public virtual Client ClientKeyNavigation { get; set; }
        public virtual Role RoleKeyNavigation { get; set; }
        public virtual User UserKeyNavigation { get; set; }
    }
}
