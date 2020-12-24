using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyServices.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public MainViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
    }
}
