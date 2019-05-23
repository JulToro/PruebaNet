using PruebaNet.Datos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class Order: BaseEntity
    {
        public string Comments { get; set; }
        public DateTime RegisterDate { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual OrderClient OrderClient { get; set; }
    }
}
