using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaNet.Datos.EntitiesTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.MapBD
{
    class OrderClientMap
    {
        public OrderClientMap(EntityTypeBuilder<OrderClient> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            //entityBuilder.HasOne(t => t.Client)
            //             .WithOne(b => b.OrderClient)
            //             .HasForeignKey<Client>(b => b.Id);
            //entityBuilder.HasOne(t => t.Employee)
            //             .WithOne(b => b.OrderClient)
            //             .HasForeignKey<Employee>(b => b.Id);
        }
    }
}
