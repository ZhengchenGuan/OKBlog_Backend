using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OKBLOGAPI.Domain;
using OKBLOGAPI.Service.Interface;
using OKBLOGAPI.Service.Service;
using OKBLOGAPI.Repository;
using OKBLOGAPI.Repository.Interface;

namespace OKBLOGAPI
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
            var OKBLOGSQL = Configuration.GetConnectionString("OKBLOGDatabase");

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "OKBLOGAPI", Version = "v1" });
            });

            services.AddDbContext<OKBLOGContext>(options =>
            {
                options.UseSqlServer(OKBLOGSQL);
            });

            InjectServices(services);
            InjectRepositories(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OKBLOGAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IBookingService, BookingService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IRestaurantService, RestaurantService>();
            services.AddTransient<ITableService, TableService>();
        }

        private static void InjectRepositories(IServiceCollection services)
        {
            services.AddTransient<IBookingRepository, BookingRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IRestaurantRepository, RestaurantRepository>();
            services.AddTransient<ITableRepository, TableRepository>();
        }
    }
}
