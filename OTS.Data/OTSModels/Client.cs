using System;
using System.Collections.Generic;

namespace OTS.Data.OTSModels
{
    public partial class Client
    {
        public Client()
        {
            ClientContact = new HashSet<ClientContact>();
            Customer = new HashSet<Customer>();
            DocumentMaster = new HashSet<DocumentMaster>();
            DocumentSubmission = new HashSet<DocumentSubmission>();
            Feedback = new HashSet<Feedback>();
            Incident = new HashSet<Incident>();
            Kxmaster = new HashSet<Kxmaster>();
            Location = new HashSet<Location>();
            Reward = new HashSet<Reward>();
            Submission = new HashSet<Submission>();
            User = new HashSet<User>();
            UserRole = new HashSet<UserRole>();
        }

        public int ClientKey { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Status { get; set; }
        public string DocumentPath { get; set; }

        public virtual ICollection<ClientContact> ClientContact { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<DocumentMaster> DocumentMaster { get; set; }
        public virtual ICollection<DocumentSubmission> DocumentSubmission { get; set; }
        public virtual ICollection<Feedback> Feedback { get; set; }
        public virtual ICollection<Incident> Incident { get; set; }
        public virtual ICollection<Kxmaster> Kxmaster { get; set; }
        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<Reward> Reward { get; set; }
        public virtual ICollection<Submission> Submission { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
