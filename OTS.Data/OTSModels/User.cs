using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class User
    {
        public User()
        {
            DocumentSubmission = new HashSet<DocumentSubmission>();
            Feedback = new HashSet<Feedback>();
            Incident = new HashSet<Incident>();
            Reward = new HashSet<Reward>();
            Submission = new HashSet<Submission>();
            UserRole = new HashSet<UserRole>();
        }

        public int UserKey { get; set; }
        public int ClientKey { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public int ManagerUserKey { get; set; }

        public virtual ICollection<DocumentSubmission> DocumentSubmission { get; set; }
        public virtual ICollection<Feedback> Feedback { get; set; }
        public virtual ICollection<Incident> Incident { get; set; }
        public virtual ICollection<Reward> Reward { get; set; }
        public virtual ICollection<Submission> Submission { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
        public virtual Client ClientKeyNavigation { get; set; }
        public virtual User ManagerUserKeyNavigation { get; set; }
        public virtual ICollection<User> InverseManagerUserKeyNavigation { get; set; }
    }
}
