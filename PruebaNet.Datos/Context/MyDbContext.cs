using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PruebaNet.Utils;
using PruebaNet.Utils.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNet.Utils.Context
{
    public class MyDbContext: DbContext
    {
        DbContextOptionsBuilder optionsDb;
        public MyDbContext(IOptions<StorageSettings> options)
        {
            optionsDb.UseSqlServer(options.Value.Storage.ConnectionString);
            optionsDb.UseLazyLoadingProxies();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }


    }
}
