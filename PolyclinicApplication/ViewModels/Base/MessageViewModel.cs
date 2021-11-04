using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace PolyclinicApplication.ViewModels.Base
{
    internal class MessageViewModel : ViewModel
    {
        private string _message;

        public string Message
        {
            get => _message;
            set => Set(ref _message, value);
        }

        private SolidColorBrush _color;

        public SolidColorBrush Color
        {
            get => _color;
            set => Set(ref _color, value);

        }

        private bool _success;

        public bool Success
        {
            get => _success;
            set => Set(ref _success, value);

        }

        public bool HasMessage => !string.IsNullOrEmpty(_message);
    }
}
