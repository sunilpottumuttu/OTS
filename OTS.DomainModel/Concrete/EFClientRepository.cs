using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OTS.DomainModel.Abstract;
using Entities = OTS.DomainModel.Entities;
using DB= OTS.Data.OTSModels;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using OTS.DomainModel.Exceptions;

namespace OTS.DomainModel.Concrete
{
    public class EFClientRepository : IClientRepository
    {
        private readonly ILogger<EFClientRepository> _logger;
        public string CurrentUser { get; set; } = string.Empty;
        public DateTime CurrentDate { get; set; } = DateTime.Now;

        public EFClientRepository(ILogger<EFClientRepository> logger)
        {
            this._logger = logger;
        }


        public async Task<IEnumerable<Entities.Client>> GetClients()
        {
            var results = new List<Entities.Client>();
            using (var context = new DB.ZZTOPContext())
            {
                var dbResults = await context.Client.ToListAsync();

                foreach (var item in dbResults)
                {
                    results.Add(new Entities.Client()
                    {
                        ClientKey = item.ClientKey,
                        Name = item.Name,
                        Address = item.Address,
                        City = item.City,
                        State = item.State,
                        Zip = item.Zip,
                        Status = item.Status,
                        DocumentPath = item.DocumentPath
                    });
                }

                return results;
            }
        }

        public async Task<Entities.Client> GetClientById(int clientKey)
        {
            var result = new Entities.Client();
            using (var context = new DB.ZZTOPContext())
            {
                var dbResult = await (from c in context.Client where c.ClientKey == clientKey select c).FirstOrDefaultAsync();

                if(dbResult==null)
                {
                    return null;
                }

                result.ClientKey = dbResult.ClientKey;
                result.Name = dbResult.Name;
                result.Address = dbResult.Address;
                result.City = dbResult.City;
                result.State = dbResult.State;
                result.Zip = dbResult.Zip;
                result.Status = dbResult.Status;
                result.DocumentPath = dbResult.DocumentPath;
            }
            return result;
        }
    
        
        public async Task<int?> AddClient(Entities.Client client)
        {
            int? result = null;
            using (var context = new DB.ZZTOPContext())
            {
                var dbRecord = new DB.Client();
                
                dbRecord.Name = client.Name;
                dbRecord.Address = client.Address;
                dbRecord.City = client.City;
                dbRecord.State = client.State;
                dbRecord.Zip = client.Zip;
                dbRecord.Status = client.Status;
                dbRecord.DocumentPath = client.DocumentPath;

                context.Entry(dbRecord).State = EntityState.Added;
                context.Client.Add(dbRecord);
                await context.SaveChangesAsync();
                result = dbRecord.ClientKey;
                return result;
            }
        }

        public async Task<int?> UpdateClient(Entities.Client client)
        {
            int? result = null;

            using (var context = new DB.ZZTOPContext())
            {
                var dbRecord = await context.Client.Where(x => x.ClientKey== client.ClientKey).FirstOrDefaultAsync();

                if (dbRecord == null)
                {
                    throw new InvalidDataException("clientkey not found");
                }

                dbRecord.Name = client.Name;
                dbRecord.Address = client.Address;
                dbRecord.City = client.City;
                dbRecord.State = client.State;
                dbRecord.Zip = client.Zip;
                dbRecord.Status = client.Status;
                dbRecord.DocumentPath = client.DocumentPath;

                context.Entry(dbRecord).State = EntityState.Modified;
                await context.SaveChangesAsync();
                result = dbRecord.ClientKey;
                return result;
            }

        }
    }
}
