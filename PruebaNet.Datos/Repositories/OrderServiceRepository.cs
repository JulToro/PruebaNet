using PruebaNet.Datos.Context;
using PruebaNet.Negocio.Entities;
using PruebaNet.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PruebaNet.Datos.Proyection;
using PruebaNet.Datos.Base;
using table = PruebaNet.Datos.EntitiesTable;
namespace PruebaNet.Datos.Repositories
{
    public class OrderServiceRepository : IOrder
    {
        IBaseRepository<table.OrderDetail> _orderDetailTable;
        IBaseRepository<table.Order> _orderTable;
        IBaseRepository<table.Product> _productTable;
        IBaseRepository<table.Employee> _employeeTable;
        IBaseRepository<table.Client> _clientTable;

        public OrderServiceRepository(IBaseRepository<table.OrderDetail> orderDetail,
                                      IBaseRepository<table.Order> order,
                                      IBaseRepository<table.Product> product,
                                      IBaseRepository<table.Employee> employee,
                                      IBaseRepository<table.Client> client
                                     )
        {
            _orderDetailTable = orderDetail;
            _orderTable = order;
            _productTable = product;
            _employeeTable = employee;
            _clientTable = client;
        }

        public async Task<Result<bool>> Create(Order order)
        {
            Result<bool> result = new Result<bool>();
            try
            {
                List<table.Product> listProducts = new List<table.Product>();
                List<table.OrderDetail> listOrderDetail = new List<table.OrderDetail>();

                table.Order orderNew = new EntitiesTable.Order();
                table.Client client = await _clientTable.Get(order.clientId);
                table.Employee employee = await _employeeTable.Get(order.employeeId);

                orderNew.Client = client;
                orderNew.Employee = employee;
                orderNew.Comments = order.commentary;
                orderNew.AddedDate = DateTime.Now;
                orderNew.ModifiedDate = DateTime.Now;
                orderNew.Total = order.GetTotalOrder();

                foreach (var item in order.products)
                {
                    table.OrderDetail orderDetail = new table.OrderDetail();
                    orderDetail.Product = await _productTable.Get(item.idProduct);
                    orderDetail.Commentary = item.commentary;
                    orderDetail.AddedDate = DateTime.Now;
                    orderDetail.ModifiedDate = DateTime.Now;
                    listOrderDetail.Add(orderDetail);
                }

                await _orderTable.Insert(orderNew);
                result.IsSuccess = true;

            }
            catch (Exception ex)
            {
                string exceptionText = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.ToString();
                result.IsSuccess = false;
                result.Exception = $"Ocurrio un error registrando la orden: {  exceptionText }";
            }
            return result;
        }

        public Task<Result<Order>> Get(int orderId)
        {
            throw new NotImplementedException();
        }

        Task<Result<IEnumerable<Order>>> IOrder.Get()
        {
            throw new NotImplementedException();
        }
    }
}
