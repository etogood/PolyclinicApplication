using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PolyclinicApplication.Commands.Base;
using PolyclinicApplication.Exception;
using PolyclinicApplication.Services;
using PolyclinicApplication.Stores;
using PolyclinicApplication.ViewModels;

namespace PolyclinicApplication.Commands
{
    class LoginCommand : BaseCommand
    {
        private readonly Authenticator _authenticator;
        private readonly AuthorizationViewModel _authorizationViewModel;
        private readonly WindowService _windowService;

        public LoginCommand(AuthorizationViewModel authorizationViewModel)
        {
            _authenticator = new Authenticator();
            _authorizationViewModel = authorizationViewModel;
            _windowService = new WindowService();
        }

        public override bool CanExecute(object parameter) => !_authorizationViewModel.HasErrors
                                                             && !string.IsNullOrEmpty(_authorizationViewModel.Login)
                                                             && !string.IsNullOrEmpty(_authorizationViewModel.Password);

        public override void Execute(object parameter)
        {
            var username = _authorizationViewModel.Login;
            var password = _authorizationViewModel.Password;

            _authorizationViewModel.ErrorMessage = string.Empty;

            try
            {
                _authenticator.Login(username, password);
                _windowService.ShowWindow(new MainViewModel());
                _windowService.CloseWindow(_authorizationViewModel);
            }
            catch (InvalidPasswordException)
            {
                _authorizationViewModel.ErrorMessage = "Введён неверный пароль.";
            }
            catch (UserNotFoundException)
            {
                _authorizationViewModel.ErrorMessage = "Пользователь с таким логином не найден";
            }
            catch (System.Exception)
            {
                _authorizationViewModel.ErrorMessage = "Неизвестная ошибка";
            }
        }
    }
}
