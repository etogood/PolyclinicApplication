using PolyclinicApplication.Services.Interfaces;
using PolyclinicApplication.ViewModels;
using PolyclinicApplication.Views.Windows;
using System.Windows;
using PolyclinicApplication.ViewModels.Base;

namespace PolyclinicApplication.Services
{
    internal class WindowService : IWindowService
    {
        public void CloseWindow(object viewModel)
        {
            switch (viewModel)
            {
                case AuthorizationViewModel:
                    foreach (Window window in Application.Current.Windows)
                        if(window is AuthorizationWindow)
                            window.Close();
                    break;

                case MainViewModel:
                    foreach (Window window in Application.Current.Windows)
                        if (window is MainWindow)
                            window.Close();
                    break;
            }
        }

        public void ShowWindow(object viewModel)
        {
            switch (viewModel)
            {
                case AuthorizationViewModel:
                    var authWindow = new AuthorizationWindow();
                    authWindow.Show();
                    break;

                case MainViewModel:
                    var mainWindow = new MainWindow();
                    mainWindow.Show();
                    break;
            }
        }
    }
}