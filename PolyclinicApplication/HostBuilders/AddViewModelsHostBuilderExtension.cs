using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PolyclinicApplication.ViewModels;

namespace PolyclinicApplication.HostBuilders
{
    public static class AddViewModelsHostBuilderExtension
    {
        public static IHostBuilder AddViewModel(this IHostBuilder host)
        {
            return host.ConfigureServices(service =>
            {
                service.AddSingleton<AuthorizationViewModel>();
            });
        }
    }
}