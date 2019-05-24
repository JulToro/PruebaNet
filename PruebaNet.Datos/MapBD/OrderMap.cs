using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaNet.Datos.EntitiesTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.MapBD
{
    public class OrderMap
    {
        public OrderMap(EntityTypeBuilder<Order> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Comments).IsRequired();
            entityBuilder.HasMany(t => t.OrderDetail)
                         .WithOne(b => b.Order);
            //entityBuilder.HasOne(e => e.OrderClient).WithMany(e => e.Orders).HasForeignKey(e => e.Id);

        }
    }
}
