using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Evangelizacion.Views;

namespace Evangelizacion
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LectioDivinaPage();
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
