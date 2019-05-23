namespace PruebaNet.Negocio.Services
{
    using PruebaNet.Negocio.Entities;
    using PruebaNet.Negocio.Services.InterfaceServices;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class OrderService : IOrderService
    {
        public Task<Result<bool>> Create(Order order)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<bool>> Delete(Order order)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<IEnumerable<Order>>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<IEnumerable<Order>>> GetbyClientId(int clientId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<Order>> GetbyIdOrder(long orderId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result<bool>> Update(Order order)
        {
            throw new System.NotImplementedException();
        }
    }
}
