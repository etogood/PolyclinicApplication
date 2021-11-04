using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolyclinicApplication.Stores;
using PolyclinicApplication.ViewModels.Base;

namespace PolyclinicApplication.Factories
{
    interface IViewModelFactory
    {
        public ViewModel CreateViewModel(ViewType viewType);
    }
}
