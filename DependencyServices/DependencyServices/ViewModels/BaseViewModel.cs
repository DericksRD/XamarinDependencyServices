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

        #region NotifyPropertyChanged
        protected void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
