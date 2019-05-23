using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaNet.Datos.EntitiesTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.MapBD
{
    class ClientMap
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

            entityBuilder.HasOne(t => t.OrderClient)
             .WithOne(b => b.Client)
             .HasForeignKey<OrderClient>(b => b.Id);

            //entityBuilder.HasOne(t => t.Person)
            //            .WithOne(t => t.Client)
            //            .HasForeignKey<Person>(b => b.Id);

        }
    }
}
