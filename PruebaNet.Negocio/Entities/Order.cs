namespace PruebaNet.Negocio.Entities
{
    using PruebaNet.Negocio.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Order : IOrder
    {
        public Int64 clientId { get; }
        public Int64 employeeId { get; }
        public List<Product> products { get; }
        public string commentary { get; }

        public Order(Int64 clientId, Int64 employeeId, List<Product> listProducts, string commentary)
        {
            this.clientId = clientId;
            this.employeeId = employeeId;
            this.products = listProducts;
            this.commentary = commentary;            
        }

        public Double GetTotalOrder()
        {
            return products.Sum(q=>q.value);
        }

        public bool Validate()
        {            
            if (this.clientId == 0)
            {
                throw new Exception("The client doesn't exist for the Order");
            }
            if (this.products.Count==0)
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
