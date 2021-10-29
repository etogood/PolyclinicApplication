using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace PolyclinicApplication.HostBuilders
{
    public static class AddConfigurationHostBuilderExtension
    {
        public static IHostBuilder AddConfiguration(this IHostBuilder host)
        {
            host.ConfigureAppConfiguration(cfg =>
            {
                cfg.AddJsonFile("appsettings.json", true, true);
                cfg.AddEnvironmentVariables();
            });

            return host;
        }
    }
}