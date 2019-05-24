using PruebaNet.Datos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class PLU: BaseEntity
    {
        public int NumberPLU { get; set; }
        public virtual Product Product { get; set; }


    }
}
