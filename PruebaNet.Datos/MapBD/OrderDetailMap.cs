﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaNet.Datos.EntitiesTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.MapBD
{
    public class OrderDetailMap
    {
        public OrderDetailMap(EntityTypeBuilder<OrderDetail> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Commentary).IsRequired();
            //entityBuilder.HasOne(e => e.Order).WithMany(e => e.OrderDetails).HasForeignKey(e => e.Id);
        }
    }
}
