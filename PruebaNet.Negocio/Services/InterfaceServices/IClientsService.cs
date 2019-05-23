using PruebaNet.Negocio.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaNet.Negocio.Services.InterfaceServices
{
    public interface IClientsServices
    {
        Task<Result<IEnumerable<Client>>> GetAll();
        Task<Result<Client>> GetClient(int clientId);
        Task<Result<bool>> Create(Client client);
        Task<Result<bool>> Update(Client client);
        Task<Result<bool>> Delete(Client client);
    }
}
