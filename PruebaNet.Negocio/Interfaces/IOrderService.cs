namespace PruebaNet.Negocio.Interfaces
{
    using PruebaNet.Negocio.Entities;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IOrderService
    {
        Task<Result<IEnumerable<Order>>> GetAll();
        Task<Result<IEnumerable<Order>>> GetOrderbyClientId(Int64 clientId);
        Task<Result<Order>> GetOrderbyId(Int64 orderId);
        Task<Result<bool>> CreateOrder(Order order);
    }
}
