using MVVM_implementacion_Jerh.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using MVVM_implementacion_Jerh.Modelo;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_Jerh.VistaModelo
{
    public class VMpage2 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Musuarios> listausuarios{ get; set; }
        #endregion

        #region Contructor
        public VMpage2(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
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
        public void Mostrarusuarios() {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre="Orlando",Imagen="https://i.ibb.co/Qv0HsPy/mapache.png"
                },
                new Musuarios
                {
                    Nombre="Copito",Imagen="https://i.ibb.co/LpYpyzw/copo-de-nieve.png"
                },
                new Musuarios
                {
                    Nombre="Eloy",Imagen="https://i.ibb.co/sP671j9/conejo.png"
                }

            };
        }
        public async Task Alerta(Musuarios parametros)
        {
            await DisplayAlert("Titulo", parametros.Nombre, "Ok");
        }
        #endregion.
        #region CONTRUCTOR
        public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        public ICommand Alertacommand => new Command<Musuarios>(async (p) => await Alerta(p));
        #endregion.
    }
}
