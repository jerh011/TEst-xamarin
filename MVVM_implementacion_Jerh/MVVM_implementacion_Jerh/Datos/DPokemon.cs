using System;
using System.Collections.Generic;
using System.Text;
using MVVM_implementacion_Jerh.Modelo;
using MVVM_implementacion_Jerh.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Firebase.Database;
using Xamarin.Essentials;

namespace MVVM_implementacion_Jerh.Datos
{
    public class DPokemon
    {
        public async Task Insertarpokemon(Mpokemon parametros)
        {
            await Cconexion.firebase.Child("Pokemon").PostAsync(new Mpokemon
            {
                Colorfondo = parametros.Colorfondo,
                ColorPoder = parametros.Colorfondo,
                Icono = parametros.Icono,
                Nombre = parametros.Nombre,
                NroOrden = parametros.NroOrden,
                Poder = parametros.Poder

            });

        }
        public async Task<ObservableCollection<Mpokemon>> MostrarPokemon()
        { /*
        return (await Cconexion.firebase.Child("Pokemon")
                .OnceAsync<Mpokemon>())
                .Select(item=>new Mpokemon
                { 
                    Idpokemon=item.Key,
                    Nombre=item.Object.Nombre,
                    Colorfondo = item.Object.Colorfondo,
                    ColorPoder = item.Object.Colorfondo,
                    Icono = item.Object.Icono,
                    NroOrden = item.Object.NroOrden,
                    Poder = item.Object.Poder

                }).ToList();
            */
            var data = await Task.Run(() => Cconexion.firebase
                .Child("Pokemon")
                .AsObservable<Mpokemon>()
                .AsObservableCollection());
            return data;

        }


        public async Task Eliminarpokemon(string ID)
        {
            await Cconexion.firebase.Child("Pokemon").Child(ID).DeleteAsync();
        }
    }
}