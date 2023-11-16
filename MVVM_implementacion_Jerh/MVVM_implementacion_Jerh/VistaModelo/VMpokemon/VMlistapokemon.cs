using MVVM_implementacion_Jerh.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_Jerh.Modelo;
using MVVM_implementacion_Jerh.Vista.Pokemon;
using MVVM_implementacion_Jerh.Datos;

namespace MVVM_implementacion_Jerh.VistaModelo.VMpokemon
{
    public class VMlistapokemon:BaseViewModel
    {
        ////////////////////////////


        #region VARIABLES
       

        List<Mpokemon> _Listapokemon;
        #endregion
        #region Contructor
        public VMlistapokemon(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarpokemon();
        }
        #endregion
        #region Objetivo;
        public List<Mpokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set { SetValue(ref _Listapokemon, value); }
        }

        #endregion
        #region PROCESOS
        public async Task Mostrarpokemon()
        {
            var funcion = new DPokemon();
            Listapokemon = await funcion.MostrarPokemon();
        }

        public async Task IrARegistro()
        {
            await Navigation.PushAsync(new Registrarpokemon());
        }
        public void Sumar()
        {
          
        }
       
        #endregion.
       
        #region COMANDOS
        public ICommand IrARegistrocommand => new Command(async () => await IrARegistro());
        public ICommand Suymarcommand => new Command(Sumar);
        #endregion







        ///////////////////////////
    }
}
