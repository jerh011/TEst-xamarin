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
        VMlistapokemon vm;
        public Listapokemon()
        { 
            InitializeComponent();
          vm= new VMlistapokemon(Navigation);
            BindingContext = vm;
            this.Appearing += Listapokemon_Appearing;
        }



        private async void Listapokemon_Appearing(object sender, EventArgs e)
        {
            await vm.Mostrarpokemon();
        }
    }
}