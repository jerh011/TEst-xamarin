using MVVM_implementacion_Jerh.Modelo;
using MVVM_implementacion_Jerh.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_Jerh.VistaModelo
{
    public class VMmenuprincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Mmenuprincipal> listaPagina{ get; set; }
        #endregion

        #region Contructor
        public VMmenuprincipal(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPagina();
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
     /*   public async Task Volver()
        {
            await Navigation.PopAsync();
        }
     */
        public void ProcesoSimple()
        {

        }
        public void MostrarPagina()
        {
            listaPagina = new List<Mmenuprincipal>
            {
                new Mmenuprincipal
                {
                    Paginas="xd",
                    Iconos="https://i.ibb.co/yy9q8x5/charmander.png"
                },
                new Mmenuprincipal
                {
                    Paginas="hola",
                    Iconos="https://i.ibb.co/d2H6zYW/bullbasaur.png"
                },
                new Mmenuprincipal
                {
                    Paginas="Carlos",
                    Iconos="https://i.ibb.co/MhmHW9G/dratini.png"
                }
            };
        }
        public async Task Navegar(Mmenuprincipal parametros)
        {
            string pagina= parametros.Paginas;
            if (pagina.Contains("xd"))
            {
                await Navigation.PushAsync(new Page1());
            }
            if (pagina.Contains("hola"))
            {
                await Navigation.PushAsync(new Page2());
            }
            if (pagina.Contains("Carlos"))
            {
                await Navigation.PushAsync(new Crudpokemon());
            }
        }
        #endregion.
        #region CONTRUCTOR
        //public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        public ICommand Navegarcommand => new Command<Mmenuprincipal>(async (p) => await Navegar(p));
        #endregion.
    }
}

