using MVVM_implementacion_Jerh.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_implementacion_Jerh.Modelo;
namespace MVVM_implementacion_Jerh.VistaModelo.VMpokemon
{
    public class VMregistropokemon: BaseViewModel
    {
        ////////////////////////////


        #region VARIABLES
        string _TxtColorFondo;
        string _TxtColorPoder;
        string _TxtNombre;
        string _TxtNro;
        string _TxtPoder;
        string _TxtIcono;
        #endregion
        #region Contructor
        public VMregistropokemon(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Objetivo;
        public string TxtColorFondo
        {
            get { return _TxtColorFondo; }
            set { SetValue(ref _TxtColorFondo, value); }
        }
        public string TxtColorPoder
        {
            get { return _TxtColorPoder; }
            set { SetValue(ref _TxtColorPoder, value); }
        }
        public string TxtNombre
        {
            get { return _TxtNombre; }
            set { SetValue(ref _TxtNombre, value); }
        }
        public string TxtNro
        {
            get { return _TxtNro; }
            set { SetValue(ref _TxtNro, value); }
        }
        public string TxtPoder
        {
            get { return _TxtPoder; }
            set { SetValue(ref _TxtPoder, value); }
        }
        public string TxtIcono
        {
            get { return _TxtIcono; }
            set { SetValue(ref _TxtIcono, value); }
        }

        #endregion
        #region PROCESOS
        public async Task NavegarPage2()
        {
            await Navigation.PushAsync(new Page2());
        }
        
        public void GetFecha()
        {
            DatePicker datePicker = new DatePicker
            {
                MinimumDate = new DateTime(2023, 1, 1),
                MaximumDate = new DateTime(2023, 12, 31),
                Date = new DateTime(2023, 10, 26)
            };
        }

        #endregion.
        #region CONTRUCTOR

        #endregion.
        #region COMANDOS
        //public ICommand PNavegarpagina2command => new Command(async () => await NavegarPage2());
       // public ICommand Suymarcommand => new Command(Sumar);
        #endregion







        ///////////////////////////


    }
}
