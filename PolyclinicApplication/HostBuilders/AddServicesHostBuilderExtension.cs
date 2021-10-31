using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PolyclinicApplication.Data.Models;
using PolyclinicApplication.Services;
using PolyclinicApplication.Services.Interfaces;

namespace PolyclinicApplication.HostBuilders
{
    internal static class AddServicesHostBuilderExtension
    {
        public static IHostBuilder AddServices(this IHostBuilder host)
        {
            return host.ConfigureServices(services =>
            {
                services.AddSingleton<IDataService<User>, UserService>();
            });
        }
    }
}