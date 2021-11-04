using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PolyclinicApplication.Factories;

namespace PolyclinicApplication.HostBuilders
{
    static class AddFactoriesHostBuilderExtension
    {
        public static IHostBuilder AddFactories(this IHostBuilder? host)
        {
            return host.ConfigureServices(services =>
            {
                services.AddSingleton<IViewModelFactory, ViewModelFactory>();
            });
        }
    }
}
