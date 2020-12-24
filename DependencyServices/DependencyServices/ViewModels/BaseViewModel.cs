using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DependencyServices.ViewModels
{
    abstract class BaseViewModel : INotifyPropertyChanged
    {
        //Atributes:
        protected INavigationService NavigationService { get; }

        //Methods:
        #region BaseViewModel
        protected BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
