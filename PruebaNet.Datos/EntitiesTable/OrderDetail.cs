using PruebaNet.Datos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class OrderDetail: BaseEntity
    {
        public string Commentary { get; set; }
        public virtual  Product Product { get; set; }
        public virtual Order Order { get; set; }
        
    }
}
