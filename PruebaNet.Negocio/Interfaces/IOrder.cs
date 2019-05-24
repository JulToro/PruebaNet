using PruebaNet.Negocio.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaNet.Negocio.Interfaces
{
    public interface IOrder
    {
        Task<Result<IEnumerable<Order>>> Get();
        Task<Result<Order>> Get(int orderId);
        Task<Result<bool>> Create(Order order);
    }
}
