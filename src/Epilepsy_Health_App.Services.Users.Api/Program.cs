using Joint.Logging;
using Joint.Secrets.Vault;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Epilepsy_Health_App.Services.Users.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseVault();
                })
            .UseLogging();
            
    }
}
