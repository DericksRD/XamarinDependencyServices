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
        /// <summary> 
        /// It implement the Invoke method from 
        /// PropertyChanged in the subclasses.
        /// </summary>
        /// <param name="propertyName">
        /// I usually use nameof(ThisProperty)
        /// </param>
        protected void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
