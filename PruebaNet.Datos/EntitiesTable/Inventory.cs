using PruebaNet.Datos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class Inventory: BaseEntity
    {
        public int Cantidad { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
