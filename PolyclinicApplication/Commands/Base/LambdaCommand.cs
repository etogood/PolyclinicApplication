using System;
using System.Windows.Input;

namespace PolyclinicApplication.Commands.Base
{
    internal abstract class LambdaCommand : BaseCommand
    {
        public Action<object> _Execute { get; set; }
        public Func<object, bool> _CanExecute { get; set; }

        public LambdaCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _Execute = Execute ?? throw new ArgumentException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        public override void Execute(object parameter) => _Execute(parameter);
        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;
    }
}