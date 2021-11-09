using System;
using Microsoft.Data.SqlClient;
using PolyclinicApplication.Commands.Base;
using PolyclinicApplication.ViewModels;

namespace PolyclinicApplication.Commands
{
    internal class AddNewPatientCommand : BaseCommand
    {
        private readonly MainViewModel _mainViewModel;

        public AddNewPatientCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public override bool CanExecute(object parameter) => !_mainViewModel.HasErrors
                                                             && _mainViewModel.CanExecute();

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}