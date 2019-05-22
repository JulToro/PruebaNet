using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public string Commentary { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
        
    }
}
