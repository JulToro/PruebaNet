using PruebaNet.Datos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class Category: BaseEntity
    {
        public string Name { get; set; }
        public int Tax { get; set; }
        public virtual Product Product { get; set; }
    }
}
