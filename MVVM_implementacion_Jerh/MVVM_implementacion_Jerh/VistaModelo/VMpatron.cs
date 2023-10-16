using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_implementacion_Jerh.VistaModelo
{
    public class VMpatron:BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion

        #region Contructor
        public VMpatron(INavigation navigation) { 
        Navigation = navigation;
        }
        #endregion

        #region Objetivo;
        public string Texto {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcecesoAsyncrono()
        { 
        }

        public void ProcesoSimple() { 
        
        }
        #endregion.
        #region CONTRUCTOR
        public ICommand ProcesoAsynCommand => new Command(async ()=> await ProcecesoAsyncrono());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion.
    }
}
