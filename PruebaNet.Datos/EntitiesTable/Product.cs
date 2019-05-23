using PruebaNet.Datos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public virtual Inventory Inventory { get; set; }
        public virtual Category Category { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
        public virtual PLU PLU { get; set; }
    }
}
