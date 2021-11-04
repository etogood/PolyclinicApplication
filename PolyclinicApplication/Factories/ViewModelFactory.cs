using PolyclinicApplication.Exception;
using PolyclinicApplication.Stores;
using PolyclinicApplication.ViewModels;
using PolyclinicApplication.ViewModels.Base;

namespace PolyclinicApplication.Factories
{
    internal class ViewModelFactory : IViewModelFactory
    {
        private readonly NavigationStore _navigationStore;

        public ViewModelFactory(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public ViewModel CreateViewModel(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.Authorization:
                    return new AuthorizationViewModel(_navigationStore);
                case ViewType.Main:
                    return new MainViewModel(_navigationStore);

                default:
                    throw new CreateViewModelException();
            }
        }
    }
}