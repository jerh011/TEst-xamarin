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
using System.Collections.ObjectModel;

namespace MVVM_implementacion_Jerh.VistaModelo.VMpokemon
{
    public class VMlistapokemon:BaseViewModel
    {
        ////////////////////////////


        #region VARIABLES
       

       // ObservableCollection<Mpokemon> _Listapokemon;//tiempo real 
       List<Mpokemon> _Listapokemon;// este no sirve para el tiempo real
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
            set
            {
                SetValue(ref _Listapokemon, value);
                OnpropertyChanged();
            }
        }
        #endregion
        #region PROCESOS
        public async Task Mostrarpokemon()
        {
            var funcion = new DPokemon();
            Listapokemon = await funcion.MostrarPokemon2();
        }

        public async Task IrARegistro()
        {
            await Navigation.PushAsync(new Registrarpokemon());
        }
       
        #endregion.

        #region COMANDOS
        public ICommand IrARegistrocommand => new Command(async () => await IrARegistro());
       
        #endregion
    }
}
