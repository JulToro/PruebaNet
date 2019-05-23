using PruebaNet.Negocio.Entities;
using PruebaNet.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNet.Datos.Repositories
{
    public class ClientsRepository : IClient
    {
        public Task<Result<bool>> Create(Client client)
        {


            throw new NotImplementedException();
        }

        public Task<Result<bool>> Delete(Client client)
        {
            throw new NotImplementedException();
        }

        public Task<Result<IEnumerable<Client>>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Result<Client>> Get(int clientId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<bool>> Update(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
