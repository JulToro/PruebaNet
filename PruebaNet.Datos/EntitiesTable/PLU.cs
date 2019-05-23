using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class PLU
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
