using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolyclinicApplication.ViewModels.Base;

namespace PolyclinicApplication.Stores
{
    public enum ViewType
    {
        Authorization
    }

    internal interface INavigationStore
    {
        ViewModel CurrentViewModel { get; set; }
        event Action CurrentViewModelChanged;
    }
}
