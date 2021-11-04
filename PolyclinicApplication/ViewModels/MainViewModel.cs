using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolyclinicApplication.Stores;
using PolyclinicApplication.ViewModels.Base;

namespace PolyclinicApplication.ViewModels
{
    class MainViewModel : ViewModel
    {
        private readonly INavigationStore _navigationStore;
        private readonly ErrorViewModel _errorViewModel;

        public MessageViewModel MessageViewModel { get; }

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public MainViewModel()
        {
            _errorViewModel = new ErrorViewModel();
            MessageViewModel = new MessageViewModel();
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
                if(string.IsNullOrEmpty(FirstName))
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
                if (string.IsNullOrEmpty(DateOfBirth.ToShortDateString()))
                    _errorViewModel.AddError(nameof(DateOfBirth), "Введите дату рождения");
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

        #endregion

        #region Documents

        private string _passport;

        public string Passport
        {
            get => _passport;
            set
            {
                if (!Set(ref _passport, value)) return;
                _errorViewModel.ClearErrors(nameof(Passport));
                if (string.IsNullOrEmpty(Passport))
                    _errorViewModel.AddError(nameof(Passport), "Заполните данное поле");
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
                if (string.IsNullOrEmpty(DateOfIssue.ToShortDateString()))
                    _errorViewModel.AddError(nameof(DateOfIssue), "Заполните данное поле");
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

        #endregion

        #endregion
    }
}
