namespace PruebaNet.Negocio.Services
{
    using PruebaNet.Negocio.Entities;
    using PruebaNet.Negocio.Interfaces;
    using PruebaNet.Negocio.Services.InterfaceServices;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class OrderService : IOrderService
    {
        private readonly IOrder _iOrder;

        public OrderService(IOrder iOrder)
        {
            this._iOrder = iOrder;
        }
        public async Task<Result<bool>> Create(Order order)
        {
            return await _iOrder.Create(order);
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
