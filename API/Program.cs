using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace SynergyERP
{
    public class Program
    {
        public static void main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => { webBuilder.UserStartup < Startup(); });        
    }
}
