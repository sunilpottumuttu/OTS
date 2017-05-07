using System;
using System.Collections.Generic;
using System.Text;

namespace OTS.DomainModel.Entities
{
    public class Client:BaseEntity
    {
        public int ClientKey { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Status { get; set; }
        public string DocumentPath { get; set; }
    }
}
