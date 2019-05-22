using PruebaNet.Negocio.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaNet.Negocio.Interfaces
{
    public interface IServiceClients
    {
        Task<Result<IEnumerable<Client>>> GetAll();
        Task<Result<IEnumerable<Client>>> GetClient(int clientId);
        Task<Result<bool>> Create(Client client);
        Task<Result<bool>> Update(Client client);
        Task<Result<bool>> Delete(Client client);

    }
}
