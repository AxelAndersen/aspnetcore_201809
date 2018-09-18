using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Globalization;

namespace bWebIntro
{
    public class Program
    {
        public static void Main(string[] args)
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            var t = bWebIntro.Resource.test;


            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .ConfigureLogging((hosting, logging) =>
                {
                    logging.AddConfiguration(hosting.Configuration.GetSection("logging"));
                    logging.AddConsole();
                    logging.AddDebug();
                })
                .UseStartup<Startup>();
        }
    }
}
