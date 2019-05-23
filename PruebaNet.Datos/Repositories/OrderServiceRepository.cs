using PruebaNet.Datos.Context;
using PruebaNet.Negocio.Entities;
using PruebaNet.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PruebaNet.Datos.Proyection;

namespace PruebaNet.Datos.Repositories
{
    public class OrderServiceRepository : IOrderService
    {
        //private readonly MyDbContext _context;

        //public OrderServiceRepository(MyDbContext context) : base(context)
        //{
        //    _context = context;
        //}

        public Task<Result<bool>> Create(Order order)
        {
            var castOrder = order.ProjectedAs<EntitiesTable.Order>();
           // _context.Order.Add()
            throw new NotImplementedException();
        }

        public Task<Result<bool>> Delete(Order order)
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

        public Task<Result<Order>> GetbyIdOrder(long orderId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<bool>> Update(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<Result<IEnumerable<Order>>> GetbyClientId(int clientId)
        {
            throw new NotImplementedException();
        }
    }
}
