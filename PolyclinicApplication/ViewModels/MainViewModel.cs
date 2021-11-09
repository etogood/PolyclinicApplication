using PolyclinicApplication.Stores;
using PolyclinicApplication.ViewModels.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using PolyclinicApplication.Commands;

namespace PolyclinicApplication.ViewModels
{
    internal class MainViewModel : ViewModel
    {
        private readonly INavigationStore _navigationStore;
        private readonly ErrorViewModel _errorViewModel;

        public AddNewPatientCommand AddNewPatientCommand { get; }
        public MessageViewModel MessageViewModel { get; }

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public MainViewModel()
        {
            _errorViewModel = new ErrorViewModel();
            MessageViewModel = new MessageViewModel();
            AddNewPatientCommand = new AddNewPatientCommand(this);
        }

        #region Properties

        private string _firstName;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (!Set(ref _firstName, value)) return;
                _errorViewModel.ClearErrors(nameof(FirstName));
                if (string.IsNullOrEmpty(FirstName))
                    _errorViewModel.AddError(nameof(FirstName), "Заполните данное поле");
            }
        }

        private string _surname;

        public string Surname
        {
            get => _surname;
            set
            {
                if (!Set(ref _surname, value)) return;
                _errorViewModel.ClearErrors(nameof(Surname));
                if (string.IsNullOrEmpty(Surname))
                    _errorViewModel.AddError(nameof(Surname), "Заполните данное поле");
            }
        }

        private string _patronymic;

        public string Patronymic
        {
            get => _patronymic;
            set
            {
                if (!Set(ref _patronymic, value)) return;
                _errorViewModel.ClearErrors(nameof(Patronymic));
                if (string.IsNullOrEmpty(Patronymic))
                    _errorViewModel.AddError(nameof(Patronymic), "Заполните данное поле");
            }
        }

        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                if (!Set(ref _dateOfBirth, value)) return;
                _errorViewModel.ClearErrors(nameof(DateOfBirth));
            }
        }

        #region Address

        private string _city;

        public string City
        {
            get => _city;
            set
            {
                if (!Set(ref _city, value)) return;
                _errorViewModel.ClearErrors(nameof(City));
                if (string.IsNullOrEmpty(City))
                    _errorViewModel.AddError(nameof(City), "Заполните данное поле");
            }
        }

        private string _street;

        public string Street
        {
            get => _street;
            set
            {
                if (!Set(ref _street, value)) return;
                _errorViewModel.ClearErrors(nameof(Street));
                if (string.IsNullOrEmpty(Street))
                    _errorViewModel.AddError(nameof(Street), "Заполните данное поле");
            }
        }

        private string _house;

        public string House
        {
            get => _house;
            set
            {
                if (!Set(ref _house, value)) return;
                _errorViewModel.ClearErrors(nameof(House));
                if (string.IsNullOrEmpty(House))
                    _errorViewModel.AddError(nameof(House), "Заполните данное поле");
            }
        }

        private string _other;

        public string Other
        {
            get => _other;
            set
            {
                if (!Set(ref _other, value)) return;
                _errorViewModel.ClearErrors(nameof(Other));
            }
        }

        #endregion Address

        #region Documents

        private string _passportNumber;

        public string PassportNumber
        {
            get => _passportNumber;
            set
            {
                if (!Set(ref _passportNumber, value)) return;
                _errorViewModel.ClearErrors(nameof(PassportNumber));
                if (string.IsNullOrEmpty(PassportNumber))
                    _errorViewModel.AddError(nameof(PassportNumber), "Заполните данное поле");
            }
        }

        private DateTime _passportDate;

        public DateTime PassportDate
        {
            get => _passportDate;
            set
            {
                if (!Set(ref _passportDate, value)) return;
                _errorViewModel.ClearErrors(nameof(PassportDate));
            }
        }

        private string _passportWhoGave;

        public string PassportWhoGave
        {
            get => _passportWhoGave;
            set
            {
                if (!Set(ref _passportWhoGave, value)) return;
                _errorViewModel.ClearErrors(nameof(PassportWhoGave));
                if (string.IsNullOrEmpty(PassportWhoGave))
                    _errorViewModel.AddError(nameof(PassportWhoGave), "Заполните данное поле");
            }
        }

        private string _passportCode;

        public string PassportCode
        {
            get => _passportCode;
            set
            {
                if (!Set(ref _passportCode, value)) return;
                _errorViewModel.ClearErrors(nameof(PassportCode));
                if (string.IsNullOrEmpty(PassportCode))
                    _errorViewModel.AddError(nameof(PassportCode), "Заполните данное поле");
            }
        }

        private string _insuranceIndividualPersonalAccountNumber;

        public string InsuranceIndividualPersonalAccountNumber
        {
            get => _insuranceIndividualPersonalAccountNumber;
            set
            {
                if (!Set(ref _insuranceIndividualPersonalAccountNumber, value)) return;
                _errorViewModel.ClearErrors(nameof(InsuranceIndividualPersonalAccountNumber));
                if (string.IsNullOrEmpty(InsuranceIndividualPersonalAccountNumber))
                    _errorViewModel.AddError(nameof(InsuranceIndividualPersonalAccountNumber), "Заполните данное поле");
            }
        }

        private string _medicalInsuranceNumber;

        public string MedicalInsuranceNumber
        {
            get => _medicalInsuranceNumber;
            set
            {
                if (!Set(ref _medicalInsuranceNumber, value)) return;
                _errorViewModel.ClearErrors(nameof(MedicalInsuranceNumber));
                if (string.IsNullOrEmpty(MedicalInsuranceNumber))
                    _errorViewModel.AddError(nameof(MedicalInsuranceNumber), "Заполните данное поле");
            }
        }

        private DateTime _dateOfIssue;

        public DateTime DateOfIssue
        {
            get => _dateOfIssue;
            set
            {
                if (!Set(ref _dateOfIssue, value)) return;
                _errorViewModel.ClearErrors(nameof(DateOfIssue));
            }
        }

        private string _insuranceCompanyName;

        public string InsuranceCompanyName
        {
            get => _insuranceCompanyName;
            set
            {
                if (!Set(ref _insuranceCompanyName, value)) return;
                _errorViewModel.ClearErrors(nameof(InsuranceCompanyName));
                if (string.IsNullOrEmpty(InsuranceCompanyName))
                    _errorViewModel.AddError(nameof(InsuranceCompanyName), "Заполните данное поле");
            }
        }

        #endregion Documents

        #endregion Properties

        public void ErrorsViewModelErrorsChanged(object sender, DataErrorsChangedEventArgs e) =>
            ErrorsChanged?.Invoke(this, e);

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public bool HasErrors => _errorViewModel.HasErrors;

        public string ErrorMessage
        {
            set => MessageViewModel.Message = value;
        }

        public IEnumerable GetErrors(string propertyName) => _errorViewModel.GetErrors(propertyName);

        public bool CanExecute()
        {
            return string.IsNullOrEmpty(_city)
                   && string.IsNullOrEmpty(_firstName)
                   && string.IsNullOrEmpty(_house)
                   && string.IsNullOrEmpty(_insuranceCompanyName)
                   && string.IsNullOrEmpty(_insuranceIndividualPersonalAccountNumber)
                   && string.IsNullOrEmpty(_medicalInsuranceNumber)
                   && string.IsNullOrEmpty(_passportCode)
                   && string.IsNullOrEmpty(_passportNumber)
                   && string.IsNullOrEmpty(_passportWhoGave)
                   && string.IsNullOrEmpty(_street)
                   && string.IsNullOrEmpty(_patronymic)
                   && string.IsNullOrEmpty(_surname)
                   && string.IsNullOrEmpty(_dateOfBirth.ToShortDateString())
                   && string.IsNullOrEmpty(_dateOfIssue.ToShortDateString())
                   && string.IsNullOrEmpty(_passportDate.ToShortDateString());
        }
    }
}