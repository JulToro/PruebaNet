using PruebaNet.Datos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class Order: BaseEntity
    {
        public string Comments { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
