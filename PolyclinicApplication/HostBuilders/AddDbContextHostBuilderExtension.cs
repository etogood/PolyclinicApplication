using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PolyclinicApplication.Data.Models;

namespace PolyclinicApplication.HostBuilders
{
    internal static class AddDbContextHostBuilderExtension
    {
        public static IHostBuilder AddDbContext(this IHostBuilder host)
        {
            return host.ConfigureServices(services =>
            {
                services.AddDbContext<AppDbContext>();
                services.AddSingleton<AppDbContextFactory>();
            });
        }
    }
}