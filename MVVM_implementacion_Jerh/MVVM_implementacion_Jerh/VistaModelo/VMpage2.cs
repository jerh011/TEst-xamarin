using MVVM_implementacion_Jerh.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_Jerh.VistaModelo
{
    public class VMpage2: BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion

        #region Contructor
        public VMpage2(INavigation navigation)
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
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public void ProcesoSimple()
        {

        }
        #endregion.
        #region CONTRUCTOR
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion.
    }
}
