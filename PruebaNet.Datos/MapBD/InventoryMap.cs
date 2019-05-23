using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaNet.Datos.EntitiesTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.MapBD
{
    class InventoryMap
    {
        public InventoryMap(EntityTypeBuilder<Inventory> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Cantidad).IsRequired();
            entityBuilder.HasOne(t => t.Product)
                         .WithOne(b=> b.Inventory)
                         .HasForeignKey<Product>(b => b.Id);            

        }
    }
}
