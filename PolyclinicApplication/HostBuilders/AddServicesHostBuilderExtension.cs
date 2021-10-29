using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PolyclinicApplication.Services;

namespace PolyclinicApplication.HostBuilders
{
    internal static class AddServicesHostBuilderExtension
    {
        public static IHostBuilder AddServices(this IHostBuilder host)
        {
            return host.ConfigureServices(services =>
            {
                services.AddSingleton<UserService>();
            });
        }
    }
}