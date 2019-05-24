using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaNet.Datos.EntitiesTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.MapBD
{
    class PLUMap
    {
        public PLUMap(EntityTypeBuilder<PLU> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.NumberPLU).IsRequired();
            entityBuilder.HasOne(t => t.Product)
                         .WithOne(t => t.PLU)
                         .HasForeignKey<Product>(b => b.PLUId);

        }
    }
}
