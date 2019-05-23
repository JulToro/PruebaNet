using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PruebaNet.Datos;
using PruebaNet.Datos.Entities;
using PruebaNet.Datos.EntitiesTable;
using PruebaNet.Datos.MapBD;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.Context
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {  }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new CategoryMap(modelBuilder.Entity<Category>());
            new ClientMap(modelBuilder.Entity<Client>());
            new EmployeeMap(modelBuilder.Entity<Employee>());
            new InventoryMap(modelBuilder.Entity<Inventory>());
            new OrderClientMap(modelBuilder.Entity<OrderClient>());
            new OrderDetailMap(modelBuilder.Entity<OrderDetail>());
            new OrderMap(modelBuilder.Entity<Order>());
            new PLUMap(modelBuilder.Entity<PLU>());
            new ProductMap(modelBuilder.Entity<Product>());
        }
    }
}
