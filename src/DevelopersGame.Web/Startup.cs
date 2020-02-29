using System;
using DevelopersGame.DataAccess;
using DevelopersGame.DataAccess.Repositories;
using DevelopersGame.Domain.Abstractions;
using DevelopersGame.Domain.Services;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace DevelopersGame.Web
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddDbContext<DataContext>(options =>
            // {
            //     options
            //         .UseNpgsql(_configuration.GetConnectionString("DefaultConnection"),
            //             assembly =>
            //                 assembly.MigrationsAssembly("DevelopersGame.DataAccess.Migrations"));
            // });
            
            services
                .AddScoped<ICommandService, CommandService>()
                //.AddScoped<IDbRepository, DbRepository>()
                .AddTelegramBotClient(_configuration)
                .AddControllers()
                .AddNewtonsoftJson(options => 
                {
                    options.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                    options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                })
                .AddFluentValidation();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}