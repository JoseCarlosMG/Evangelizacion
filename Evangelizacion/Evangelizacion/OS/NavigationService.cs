using Core.Evangelizacion.OS;
using Evangelizacion.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Evangelizacion.OS
{
    public class NavigationService : INavigationService
    {
        internal INavigation Navigation { get; set; }

        public async Task GoBack() => await Navigation.PopAsync(true);

        public async Task Home() => await Navigation.PopToRootAsync(true);

        public async void NavigatePop() => await Navigation.PopAsync();

        public async Task NavigateTo(string pageKey)
        {
            if (pageKey == PagesKeys.HomePage)
            {
                await Navigation.PopToRootAsync(true);
                return;
            }
            var paginaPorNavegar = typeof(HomePage);
            switch (pageKey)
            {
                case PagesKeys.HomePage:
                    paginaPorNavegar = typeof(HomePage);
                    break;
            }
            var ultimaPagina = Navigation.NavigationStack.Where(p => p.GetType() == paginaPorNavegar).FirstOrDefault();
            if (ultimaPagina == null)
            {
                switch (pageKey)
                {
                    case PagesKeys.HomePage:
                        await Navigation.PopToRootAsync(true);
                        break;
                }
            }
        }

        public async Task NavigateTo(string pageKey, params object[] parameter)
        {
            if (pageKey == PagesKeys.HomePage)
            {
                await Navigation.PopToRootAsync(true);
                return;
            }
            var paginaPorNavegar = typeof(HomePage);
            switch (pageKey)
            {
                case PagesKeys.HomePage:
                    paginaPorNavegar = typeof(HomePage);
                    break;
            }
            var ultimaPagina = Navigation.NavigationStack.Where(p => p.GetType() == paginaPorNavegar).FirstOrDefault();
            if (ultimaPagina == null)
            {
                switch (pageKey)
                {
                    case PagesKeys.HomePage:
                        await Navigation.PushAsync(new HomePage(), true);
                        break;
                }
            }
        }
        public async void NavigateToUrl(string url) => await Xamarin.Essentials.Launcher.OpenAsync(new Uri(url));

        public Task PopModal() => throw new NotImplementedException();

        public Task PushModal(string pageKey) => null;
    }
}