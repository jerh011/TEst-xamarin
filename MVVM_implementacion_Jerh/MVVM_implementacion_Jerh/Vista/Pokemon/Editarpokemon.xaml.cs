using MVVM_implementacion_Jerh.VistaModelo.VMpokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_implementacion_Jerh.Vista.Pokemon;
using MVVM_implementacion_Jerh.VistaModelo.VMpokemon;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVM_implementacion_Jerh.Modelo;

namespace MVVM_implementacion_Jerh.Vista.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Editarpokemon : ContentPage
    {
        public Editarpokemon(Mpokemon poquimon)
        {
            InitializeComponent();
            BindingContext = new VMeditarpokemon(Navigation,poquimon);
        }
    }
}