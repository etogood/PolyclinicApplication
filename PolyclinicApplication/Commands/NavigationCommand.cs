using PolyclinicApplication.Commands.Base;
using PolyclinicApplication.Factories;
using PolyclinicApplication.Stores;

#nullable enable

namespace PolyclinicApplication.Commands
{
    internal class NavigationCommand : BaseCommand

    {
        private readonly INavigationStore _navigationStore;
        private readonly IViewModelFactory _viewModelFactory;

        public NavigationCommand(INavigationStore navigationStore, IViewModelFactory viewModelFactory)
        {
            _navigationStore = navigationStore;
            _viewModelFactory = viewModelFactory;
        }

        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object? parameter)
        {
            if (parameter == null) return;
            var viewType = (ViewType) parameter;
            _navigationStore.CurrentViewModel = _viewModelFactory.CreateViewModel(viewType);
        }
    }
}