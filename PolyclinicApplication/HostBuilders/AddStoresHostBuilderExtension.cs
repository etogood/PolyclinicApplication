using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PolyclinicApplication.Stores;

namespace PolyclinicApplication.HostBuilders
{
    static class AddStoresHostBuilderExtension
    {
        public static IHostBuilder AddStores(this IHostBuilder? host)
        {
            return host.ConfigureServices(services =>
            {
                services.AddSingleton<INavigationStore, NavigationStore>();
            });
        }
    }
}
