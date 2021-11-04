using PolyclinicApplication.ViewModels.Base;
using System;

namespace PolyclinicApplication.Stores
{
    internal class NavigationStore : INavigationStore
    {
        public event Action CurrentViewModelChanged;

        private ViewModel _currentViewModel;

        public ViewModel CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                CurrentViewModelChanged?.Invoke();
            }
        }
    }
}