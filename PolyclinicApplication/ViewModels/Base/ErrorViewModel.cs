using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PolyclinicApplication.ViewModels.Base
{
    class ErrorViewModel : INotifyDataErrorInfo
    {
        private readonly Dictionary<string, List<string>> _errors;

        public ErrorViewModel()
        {
            _errors = new Dictionary<string, List<string>>();
        } 
        
        public bool HasErrors => _errors.Any();

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        private void OnErrorsChanged(string propertyName) => ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));

        public void ClearErrors(string propertyName)
        {
            if (_errors.Remove(propertyName))
                OnErrorsChanged(propertyName);    
        }

        public IEnumerable GetErrors(string propertyName) => _errors.GetValueOrDefault(propertyName, null);

        public void AddError(string propertyName, string errorMessage)
        {
            if (!_errors.ContainsKey(propertyName))
                _errors.Add(propertyName, new List<string>());
            _errors[propertyName].Add(errorMessage);
            OnErrorsChanged(propertyName);
        }




        public bool OnlyLettersValidation(string value) => value.All(char.IsLetter);
        public bool OnlyNumbersValidation(string value) => value.All(char.IsDigit);

        public bool PasswordValidation(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var upperChars = new Regex(@"[A-Z]+");

            return hasNumber.IsMatch(password)
                   && upperChars.IsMatch(password)
                   && password.Any(char.IsPunctuation);
        }
    }
}
