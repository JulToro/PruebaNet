using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.EntitiesTable
{
    public class Category
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Tax { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
