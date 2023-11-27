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
    public class VMeditarpokemon : BaseViewModel
    {
        ////////////////////////////


        #region VARIABLES
        string _TxtColorFondo;
        string _TxtColorPoder;
        string _TxtNombre;
        string _TxtNro;
        string _TxtPoder;
        string _TxtIcono;
       public Mpokemon _poquimon { get; set; }
        #endregion
        #region Contructor
        public VMeditarpokemon(INavigation navigation, Mpokemon poquimon)
        {
            Navigation = navigation;
            _poquimon = poquimon;

        }
        #endregion
        #region Objetivo;
        public string TxtColorFondo
        {
            get { return _poquimon.Colorfondo; }
            set { SetValue(ref _TxtColorFondo, value); }
        }
        public string TxtColorPoder
        {
            get { return _poquimon.ColorPoder; }
            set { SetValue(ref _TxtColorPoder, value); }
        }
        public string TxtNombre
        {
            get { return _poquimon.Nombre; }
            set { SetValue(ref _TxtNombre, value); }
        }
       
        public string TxtNro
        {
            get { return _poquimon.NroOrden; }
            set { SetValue(ref _TxtNro, value); }
        }
        public string TxtPoder
        {
            get { return _poquimon.Poder; }
            set { SetValue(ref _TxtPoder, value); }
        }
        public string TxtIcono
        {
            get { return _poquimon.Icono; }
            set { SetValue(ref _TxtIcono, value); }
        }

        #endregion
        #region PROCESOS
        public async Task Insertar()
        {
            var funcion = new DPokemon();
            var parametros = new Mpokemon();
            parametros.Colorfondo = TxtColorFondo;
            parametros.ColorPoder = TxtColorPoder;
            parametros.Icono = TxtIcono;
            parametros.Nombre = TxtNombre;
            parametros.NroOrden = TxtNro;
            parametros.Poder = TxtPoder;
            await funcion.Insertarpokemon(parametros);
            await Volver();
        }

        public void Eliminar(Mpokemon mpokemon)
        {

            var funcion = new DPokemon();
            funcion.Eliminarpokemon(mpokemon);
            Volver();
        }

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }



        #endregion.
        #region CONTRUCTOR

        #endregion.
        #region COMANDOS
        public ICommand Insertarcommand => new Command(async () => await Insertar());
        public ICommand Eliminarcommand => new Command<Mpokemon>(async (mpokemon) =>  Eliminar(mpokemon));

        public ICommand Volvercommand => new Command(async () => await Volver());

        #endregion







        ///////////////////////////


    }
}
