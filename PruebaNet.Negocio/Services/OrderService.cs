namespace PruebaNet.Negocio.Services
{
    using PruebaNet.Negocio.Entities;
    using PruebaNet.Negocio.Interfaces;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class OrderService : IOrderService
    {
        public async Task<Result<bool>> CreateOrder(Order order)
        {
            return await this.CreateOrder(order);
        }

        public async Task<Result<IEnumerable<Order>>> GetAll()
        {
            return await this.GetAll();
        }
        public async Task<Result<IEnumerable<Order>>> GetOrderbyClientId(long clientId)
        {
            return await this.GetOrderbyClientId(clientId);
        }
        public async Task<Result<Order>> GetOrderbyId(long orderId)
        {
            return await this.GetOrderbyId(orderId);
        }
    }
}
