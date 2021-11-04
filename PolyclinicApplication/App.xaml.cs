using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PolyclinicApplication.HostBuilders;
using PolyclinicApplication.Views.Windows;
using System.Windows;

#nullable enable

namespace PolyclinicApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IHost? _host;

        private static IHostBuilder CreateHostBuilder(string[]? args = null)
        {
            return Host.CreateDefaultBuilder()
                .AddConfiguration()
                .AddViewModel()
                .AddViews()
                .AddServices()
                .AddStores()
                .AddFactories()
                .AddDbContext();
        }

        public App()
        {
            _host = CreateHostBuilder().Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _host.Start();
            if (_host == null) return;
            Window window = _host.Services.GetRequiredService<AuthorizationWindow>();
            window.Show();
            base.OnStartup(e);

        }

        protected override async void OnExit(ExitEventArgs e)
        {
            if (_host == null) return;
            await _host.StopAsync();
            _host.Dispose();
            base.OnExit(e);
        }
    }
}