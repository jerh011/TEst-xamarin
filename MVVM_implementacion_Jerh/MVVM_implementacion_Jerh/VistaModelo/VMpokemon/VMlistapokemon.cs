using MVVM_implementacion_Jerh.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_Jerh.Modelo;
using MVVM_implementacion_Jerh.Vista.Pokemon;
namespace MVVM_implementacion_Jerh.VistaModelo.VMpokemon
{
    public class VMlistapokemon:BaseViewModel
    {
        ////////////////////////////


        #region VARIABLES
        string _N1;
        string _N2;
        string _R;
        string _TipoUsuario;
        #endregion
        #region Contructor
        public VMlistapokemon(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Objetivo;
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }

        public string TipoUsuario
        {
            get { return _TipoUsuario; }
            set { SetValue(ref _TipoUsuario, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }

        public string SeleccionarTipoUsuario
        {
            get { return _TipoUsuario; }
            set
            {
                SetValue(ref _TipoUsuario, value);
                TipoUsuario = _TipoUsuario;
            }
        }

        #endregion
        #region PROCESOS
        public async Task IrARegistro()
        {
            await Navigation.PushAsync(new Registrarpokemon());
        }
        public void Sumar()
        {
          
        }
       
        #endregion.
        #region CONTRUCTOR

        #endregion.
        #region COMANDOS
        public ICommand IrARegistrocommand => new Command(async () => await IrARegistro());
        public ICommand Suymarcommand => new Command(Sumar);
        #endregion







        ///////////////////////////
    }
}
