namespace PruebaNet.Negocio.Entities
{
    using PruebaNet.Negocio.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Order : IOrder
    {
        public Int64 _clientId { get; }
        public Int64 _employeeId { get; }
        public List<Product> _products { get; }
        public string _commentary { get; }

        public Order(Int64 clientId, Int64 employeeId, List<Product> listProducts, string commentary)
        {
            this._clientId = clientId;
            this._employeeId = employeeId;
            this._products = listProducts;
            this._commentary = commentary;            
        }

        public Double GetTotalOrder()
        {
            return _products.Sum(q=>q._value);
        }

        public bool Validate()
        {            
            if (this._clientId == 0)
            {
                throw new Exception("The client doesn't exist for the Order");
            }
            if (this._products.Count==0)
            {
                throw new Exception("The order doesn't contain products");
            }
            return true;
        }

        public double Get()
        {
            throw new NotImplementedException();
        }
    }
}
