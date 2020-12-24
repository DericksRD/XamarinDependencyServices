using DependencyServices.Services;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace DependencyServices.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        //Atributes and Commands:

        #region PhoneOrientation and PreviousOrientation
        public String phoneOrientation;
        public String PhoneOrientation { 
            get
            {
                return phoneOrientation;
            }  
            
            set 
            {
                phoneOrientation = value;
                NotifyPropertyChanged(nameof(PhoneOrientation));
            }
        }
        #endregion

        public ICommand OrientationCommand { get; }

        //Methods:

        #region MainViewModel
        public MainViewModel(INavigationService navigationService) : base(navigationService)
        {
            OrientationCommand = new DelegateCommand( () =>
            {
                IDeviceOrientationService service = DependencyService.Get<IDeviceOrientationService>();
                DeviceOrientation orientation = service.GetOrientation();
                PhoneOrientation = orientation.ToString();
            });
        }
        #endregion
    }
}
