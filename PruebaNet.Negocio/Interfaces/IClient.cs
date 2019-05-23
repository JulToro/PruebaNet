using PruebaNet.Negocio.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNet.Negocio.Interfaces
{
    public interface IClient
    {
        Task<Result<IEnumerable<Client>>> Get();
        Task<Result<Client>> Get(int clientId);
        Task<Result<bool>> Create(Client client);
        Task<Result<bool>> Update(Client client);
        Task<Result<bool>> Delete(Client client);
    }
}
