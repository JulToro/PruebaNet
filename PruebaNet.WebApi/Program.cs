using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PruebaNet.WebApi.Adapters.Mappers;
using PruebaNet.WebApi.Adapters.Mappers.AutoMapper;

namespace PruebaNet.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var adapterFactory = new AutoMapperAdapterFactory();
            MapperAdapterFactory.SetCurrent(adapterFactory);
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
