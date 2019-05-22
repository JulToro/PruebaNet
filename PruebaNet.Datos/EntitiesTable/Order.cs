using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class Order
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public DateTime RegisterDate { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

        public OrderClient OrderClient { get; set; }
    }
}
