using PruebaNet.Datos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class Employee: BaseEntity
    {     
        public string Name { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
