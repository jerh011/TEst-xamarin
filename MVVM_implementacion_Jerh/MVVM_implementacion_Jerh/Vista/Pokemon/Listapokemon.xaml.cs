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
        public Listapokemon()
        {
            InitializeComponent();
            BindingContext = new VMlistapokemon(Navigation);
        }
    }
}