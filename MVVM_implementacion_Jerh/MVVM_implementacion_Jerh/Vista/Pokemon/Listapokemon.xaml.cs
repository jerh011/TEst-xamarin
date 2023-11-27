 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVM_implementacion_Jerh.VistaModelo.VMpokemon;
using MVVM_implementacion_Jerh.Vista.Pokemon;

namespace MVVM_implementacion_Jerh.Vista.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listapokemon : ContentPage
    {


        //activar solo esto para cuando este ejecutando la aplicacion en tiempo real
        /*
            public Listapokemon()
            { 
                InitializeComponent();
                BindingContext = new VMlistapokemon(Navigation);//activar solo esto para cuando este ejecutando la aplicacion en tiempo real
            }
            */
        VMlistapokemon vM;//esto es para cuando este usando lista
        public Listapokemon()
        {
            InitializeComponent();
            vM=new VMlistapokemon(Navigation);
            BindingContext=vM;
            this.Appearing += Listapokemon_Appearing;
        }

        //desactivarlo cuando este usando la aplicacion en tiempo real
        private async void Listapokemon_Appearing(object sender, EventArgs e)
        {
            await vM.Mostrarpokemon();
        }
    }
}