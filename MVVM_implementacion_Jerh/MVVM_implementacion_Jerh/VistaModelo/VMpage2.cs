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
                    Nombre="Frank",Imagen="https://i.ibb.co/zGtXvry/conejo-de-pascua.png"
                },
                new Musuarios
                {
                    Nombre="Juan",Imagen="https://i.ibb.co/6WyXntz/conejo-2.png"
                },
                new Musuarios
                {
                    Nombre="Carlos",Imagen="https://i.ibb.co/Jxp1WGb/conejo-1.png"
                },
                new Musuarios
                {
                    Nombre="Eloy",Imagen="https://i.ibb.co/rx66K3W/conejo.png"
                }
            };
        
        
        }
        #endregion.
        #region CONTRUCTOR
        public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion.
    }
}
