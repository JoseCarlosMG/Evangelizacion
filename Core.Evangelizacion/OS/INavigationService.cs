using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Evangelizacion.OS
{
    public interface INavigationService
    {
        /// <summary>Método que se usara para manejar un back</summary>
        /// <returns></returns>
        Task GoBack();
        /// <summary>Método que se usara para limpiar un stack de navegacion hasta la raiz</summary>
        /// <returns></returns>
        Task Home();
        /// <summary>Método que se usara para quitar un modal</summary>
        /// <returns></returns>
        Task PopModal();
        /// <summary>Método que se usara para mostrar un modal</summary>
        /// <param name="pageKey"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task PushModal(string pageKey);
        /// <summary> Método que se usara para navegar a una pagina sin que la pagina requiera algun parámetro</summary>
        /// <param name="pageKey"></param>
        /// <returns></returns>
        Task NavigateTo(string pageKey);
        /// <summary>Método que se usara para navegar a una pagina que requiera parametros</summary>
        /// <param name="pageKey"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task NavigateTo(string pageKey, params object[] parameter);

        void NavigatePop();

        void NavigateToUrl(string url);
    }
}