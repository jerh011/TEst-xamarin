using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
namespace MVVM_implementacion_Jerh.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmjerh-default-rtdb.firebaseio.com/");
    }
}
