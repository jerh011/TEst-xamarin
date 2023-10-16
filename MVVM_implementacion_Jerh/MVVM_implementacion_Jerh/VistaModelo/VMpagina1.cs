using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_Jerh.VistaModelo
{
    public class VMpagina1:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region Contructor
        public VMpagina1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Objetivo;
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task alerta()
        {
            DisplayAlert("Titulo", _Texto, "Okay");
        }

        public void ProcesoSimple()
        {

        }
        #endregion.
        #region CONTRUCTOR
     
        #endregion.
        #region COMANDOS
        public ICommand Alertacommand => new Command(async ()=> await alerta());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion

    }
}