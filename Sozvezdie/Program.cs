using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Sozvezdie.DAL.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Sozvezdie
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            var host = CreateHostBuilder(args).Build();

            var repositories = host.Services.GetService<ITourRepository>();
            AppInitializer.SeedData(repositories);


            host.Run();
        }

        

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
