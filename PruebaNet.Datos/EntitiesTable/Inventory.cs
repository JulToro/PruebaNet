using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class Inventory
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
