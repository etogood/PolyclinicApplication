using PolyclinicApplication.ViewModels.Base;

namespace PolyclinicApplication.Services.Interfaces
{
    internal interface IWindowService
    {
        void ShowWindow(object viewModel);

        void CloseWindow(object parameter);
    }
}