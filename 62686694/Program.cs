using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace _62686694
{
    public class Program
    {
        public static long MaxRequestBodySizeValue = 0;
        public static void Main(string[] args)
        {
            MaxRequestBodySizeValue = 20200703;
            Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development");
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureKestrel((context, options) =>
                    {
                        // Handle requests up to 50 MB
                        
                        options.Limits.MaxRequestBodySize = MaxRequestBodySizeValue;
                    })
                    .UseStartup<Startup>();
                });
    }
}
