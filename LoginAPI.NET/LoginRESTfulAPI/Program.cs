using LoginRESTfulAPI.Engine;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace LoginRESTfulAPI
{
    public class Program
    {
        public static MySQLConnector Database;

        public static void Main(string[] args)
        {
            Database = new MySQLConnector();
            Database.Connect();

            CreateHostBuilder(args).Build().Run();

            Database.Connection.Close();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
