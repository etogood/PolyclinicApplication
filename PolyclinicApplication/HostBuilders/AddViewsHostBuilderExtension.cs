using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PolyclinicApplication.ViewModels;
using PolyclinicApplication.Views.Windows;

namespace PolyclinicApplication.HostBuilders
{
    public static class AddViewsHostBuilderExtension
    {
        public static IHostBuilder AddViews(this IHostBuilder host)
        {
            return host.ConfigureServices(services =>
            {
                services.AddSingleton<AuthorizationWindow>(s =>
                    new AuthorizationWindow(s.GetRequiredService<AuthorizationViewModel>()));
            });
        }
    }
}
