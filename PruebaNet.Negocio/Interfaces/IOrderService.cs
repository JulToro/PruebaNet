namespace PruebaNet.Negocio.Interfaces
{
    using PruebaNet.Negocio.Entities;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IOrderService
    {
        Task<Result<IEnumerable<Order>>> GetAll();
        Task<Result<IEnumerable<Order>>> GetbyClientId(int clientId);
        Task<Result<Order>> GetbyIdOrder(Int64 orderId);
        Task<Result<bool>> Create(Order order);
        Task<Result<bool>> Update(Order order);
        Task<Result<bool>> Delete(Order order);
    }
}
