using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaNet.Datos.EntitiesTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.MapBD
{
    public class EmployeeMap
    {
        public EmployeeMap(EntityTypeBuilder<Employee> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.HasMany(t => t.Orders)
                         .WithOne(b => b.Employee);
            //entityBuilder.HasOne(t => t.OrderClient)
            //             .WithOne(b => b.Employee)
            //             .HasForeignKey<OrderClient>(b => b.Id);
        }
    }
}
