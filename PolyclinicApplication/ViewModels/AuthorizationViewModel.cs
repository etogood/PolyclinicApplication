using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using PolyclinicApplication.Commands;
using PolyclinicApplication.Factories;
using PolyclinicApplication.Stores;
using PolyclinicApplication.ViewModels.Base;

namespace PolyclinicApplication.ViewModels
{
    internal class AuthorizationViewModel : ViewModel, INotifyDataErrorInfo
    {
        private readonly INavigationStore _navigationStore;
        private readonly ErrorViewModel _errorViewModel;
        public MessageViewModel MessageViewModel { get; }
        public LoginCommand LoginCommand { get; }

        public AuthorizationViewModel()
        {
            LoginCommand = new LoginCommand(this);
            _errorViewModel = new ErrorViewModel();
            MessageViewModel = new MessageViewModel();
        }

        #region Properties

        private string _login;
        public string Login
        {
            get => _login;
            set
            {
                if (!Set(ref _login, value)) return;
                    _errorViewModel.ClearErrors(nameof(Login));
                if(string.IsNullOrEmpty(Login))
                    _errorViewModel.AddError(nameof(Login), "Заполните поле");
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                if (!Set(ref _password, value)) return;
                    _errorViewModel.ClearErrors(nameof(Password));
                if (string.IsNullOrEmpty(Password))
                    _errorViewModel.AddError(nameof(Password), "Заполните поле");
            }
        }

        #endregion


        public AuthorizationViewModel(INavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            LoginCommand = new LoginCommand(this);
            _errorViewModel = new ErrorViewModel();
            MessageViewModel = new MessageViewModel();
        }

        private void ErrorsViewModelErrorsChanged(object sender, DataErrorsChangedEventArgs e) => ErrorsChanged?.Invoke(this, e);

        public string ErrorMessage
        {
            set => MessageViewModel.Message = value;
        }

        public bool HasErrors => _errorViewModel.HasErrors;

        public IEnumerable GetErrors(string propertyName) => _errorViewModel.GetErrors(propertyName);

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
    }
}