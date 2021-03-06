using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FerroApp.Domain.Interfaces;
using FerroApp.Infraestructure.Data;
using FerroApp.Infraestructure.Repositories;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FerroApp.Api
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
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddControllers();
            services.AddDbContext<FerrAppContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("FerrAppConnection"))
            );
            services.AddTransient<IProductoRepository, ProductoRepository>();
            services.AddTransient<IGerenteRepository, GerenteRepository>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

            services.AddMvc().AddFluentValidation(options =>
            options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
