using PruebaNet.Negocio.Entities;
using PruebaNet.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNet.Utils.Repositories
{
    public class OrderServiceRepository : IOrderService
    {
        public Task<Result<bool>> CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<Result<IEnumerable<Order>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Result<IEnumerable<Order>>> GetOrderbyClientId(long clientId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<Order>> GetOrderbyId(long orderId)
        {
            throw new NotImplementedException();
        }
    }
}
