using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

using JWTNet.API.Repository;
using JWTNet.API.Repository.Interface;
using JWTNet.API.Services;
using Microsoft.AspNetCore.Cors;
using JWTNet.API.Services.Interface;

namespace JWTNet
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
            // Add service and create Policy with options
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                    );
            });

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(option => option.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            string connectionString = Environment.GetEnvironmentVariable("MYSQLCONNSTR_localdb");
            if (string.IsNullOrEmpty(connectionString))
            {
                //EF desarrollo
                services.AddDbContext<JWTNetAPIContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MYSQLCONNSTR_localdb_dev")));
            }
            else
            {
                services.AddDbContext<JWTNetAPIContext>(options =>
                        options.UseMySql(Configuration.GetConnectionString("MYSQLCONNSTR_localdb")));
            }
            //Repositorios
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();

            //Servicios
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ISkillService, SkillsService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("CorsPolicy");
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
