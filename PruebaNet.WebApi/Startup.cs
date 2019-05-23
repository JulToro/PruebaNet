using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PruebaNet.Datos.Context;
using PruebaNet.Datos.Entities;
using PruebaNet.Negocio.Interfaces;
using PruebaNet.Negocio.Services;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using PruebaNet.Negocio.Services.InterfaceServices;

namespace PruebaNet.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<StorageSettings>(Configuration);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "PruebaNet Exito", Version = "v1" });
                // Set the comments path for the Swagger JSON and UI.
                var basePath = AppContext.BaseDirectory;
                var xmlPath = Path.Combine(basePath, "PruebaNet.WebApi.xml");
                c.IncludeXmlComments(xmlPath);
            });
            services.AddMvcCore().AddJsonFormatters();

            //Services 
            services.AddTransient<IClientsServices, ClientsService>();
            services.AddTransient<IEmployeesService, EmployeeService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IProductsService, ProductsServices>();

            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=BDPruebaNet;Trusted_Connection=True;";// Configuration["Storage:ConnectionString"];
            //services.AddDbContext<MyDbContext>(connection=> connection.UseSqlServer(connectionString), b => b.MigrationsAssembly("Project.Api"));
            services.AddDbContext<MyDbContext>(options => options.UseSqlServer(Configuration["Storage:ConnectionString"], b => b.MigrationsAssembly("PruebaNet.WebApi")));

            //services.AddTransient<IOrderService, OrderServiceRepository>();

        }
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("MyPolicy");

            //Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            //Enable middleware to serve swagger - ui(HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "PruebaNet Exito API V1");
                c.RoutePrefix = "swagger/ui";
            });
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
