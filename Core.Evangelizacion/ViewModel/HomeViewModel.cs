using Core.Evangelizacion.OS;
using Sysne.Core.MVVM;
using Sysne.Core.OS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Evangelizacion.ViewModel
{
    public class HomeViewModel
    {
        #region Constructor
        public HomeViewModel()
        {
        }
        #endregion

        #region Properties
        #endregion

        #region Comands
        RelayCommand lectioCommand = null;

        public RelayCommand LectioCommand
        {
            get => lectioCommand ?? (lectioCommand = new RelayCommand(async () =>
            {
                await DependencyService.Get<INavigationService>().NavigateTo(PagesKeys.LectioDivinaPage);
            }));
        }
        #endregion

    }
}