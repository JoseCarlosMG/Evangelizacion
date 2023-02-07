using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Evangelizacion.Views;
using Core.Evangelizacion.OS;
using Evangelizacion.OS;

namespace Evangelizacion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new HomePage();
            Sysne.Core.OS.DependencyService.Register<NavigationService, INavigationService>(Sysne.Core.OS.DependencyService.ServiceLifetime.Singleton);
            MainPage = new NavigationPage(new HomePage());
            (Sysne.Core.OS.DependencyService.Get<INavigationService>() as NavigationService).Navigation = Current.MainPage.Navigation;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
