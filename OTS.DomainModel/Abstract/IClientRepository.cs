using OTS.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OTS.DomainModel.Abstract
{
    public interface IClientRepository
    {
        //Common
        string CurrentUser { get; set; }
        DateTime CurrentDate { get; set; }

        Task<IEnumerable<Client>> GetClients();
        Task<Client> GetClientById(int clientKey);
        Task<int?> AddClient(Client client);
        Task<int?> UpdateClient(Client client);
    }
}
