using PruebaNet.Datos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class OrderClient: BaseEntity
    {
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get;set; }
        public virtual ICollection<Order> Orders { get; set; }
        
    }
}
