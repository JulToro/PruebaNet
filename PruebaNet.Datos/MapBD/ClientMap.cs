using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaNet.Datos.EntitiesTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.MapBD
{
    public class ClientMap
    {
        public ClientMap(EntityTypeBuilder<Client> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Identification);
            entityBuilder.Property(t => t.Name);
            entityBuilder.Property(t => t.PhoneNumber);
            entityBuilder.Property(t => t.Email);
            entityBuilder.Property(t => t.Addres);
            entityBuilder.Property(t=>t.City);
            entityBuilder.HasMany(t => t.Orders)
                         .WithOne(b => b.Client);
             //.HasForeignKey<Order>(b => b.Id);
            
        }
    }
}
