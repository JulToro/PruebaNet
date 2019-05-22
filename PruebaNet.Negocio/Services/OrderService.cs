namespace PruebaNet.Negocio.Services
{
    using PruebaNet.Negocio.Entities;
    using PruebaNet.Negocio.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class OrderService : IOrderService
    {
        public async Task<Result<bool>> Create(Order order)
        {
            return await this.Create(order);
        }

        public Task<Result<bool>> Delete(Order order)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Result<IEnumerable<Order>>> GetAll()
        {
            return await this.GetAll();
        }
        public async Task<Result<IEnumerable<Order>>> GetOrderbyClientId(long clientId)
        {
            return await this.GetOrderbyClientId(clientId);
        }
        public async Task<Result<Order>> GetbyIdOrder(long orderId)
        {
            return await this.GetbyIdOrder(orderId);
        }

        public Task<Result<bool>> Update(Order order)
        {
            throw new System.NotImplementedException();
        }
    }
}
