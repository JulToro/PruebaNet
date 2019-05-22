using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PruebaNet.Datos;
using PruebaNet.Datos.Entities;
using PruebaNet.Datos.EntitiesTable;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Datos.Context
{
    public class MyDbContext: DbContext
    {
        public string Connection { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {  } 

        public DbSet<Person> Person { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderClient> OrderClient { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
