using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PruebaNet.Negocio.Entities;
using PruebaNet.Negocio.Interfaces;

namespace PruebaNet.Negocio.Services
{
    public class ClientsService : IClientsServices
    {
        private readonly IClient _iClient;
        public ClientsService(IClient iClient)
        {
            this._iClient = iClient;
        }

        public async Task<Result<bool>> Create(Client client)
        {
            if (client.Validate())
            {
               return  await _iClient.Create(client);
            }
            throw new Exception($"Create client invalid, please validate attributes");
        }

        public async Task<Result<bool>> Delete(Client client)
        {
            if (client.Validate())
            {
                return await _iClient.Delete(client);
            }
            throw new System.NotImplementedException("Delete operation hasn't been implementate");
        }

        public async Task<Result<IEnumerable<Client>>> GetAll()
        {
            return await _iClient.Get();
        }

        public async Task<Result<Client>> GetClient(int clientId)
        {
            return await _iClient.Get(clientId);
        }

        public async Task<Result<bool>> Update(Client client)
        {
            if (client.Validate())
            {
                return await _iClient.Update(client);
            }
            throw new System.NotImplementedException("Update operation hasn't been implementate");
        }
    }
}
