using DependencyServices.ViewModels;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DependencyServices
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
            InitializeComponent();
        }

        #region OnStart, OnSleep and OnResume
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        #endregion

        #region RegisterTypes
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>("Navigation");
            containerRegistry.RegisterForNavigation<MainPage, MainViewModel>("Main");
        }
        #endregion

        #region OnInitialized
        protected async override void OnInitialized()
        {
            await NavigationService.NavigateAsync(
                        $"{NavigationConstants.Navigation}/{NavigationConstants.Main}");
        }
        #endregion
    }
}
