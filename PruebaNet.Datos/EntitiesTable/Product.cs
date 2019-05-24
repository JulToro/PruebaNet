using PruebaNet.Datos.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace PruebaNet.Datos.EntitiesTable
{
    public class Product: BaseEntity
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public int InventoryId { get; set; }
        public virtual Inventory Inventory { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int PLUId { get; set; }
        public virtual PLU PLU { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }



    }
}
