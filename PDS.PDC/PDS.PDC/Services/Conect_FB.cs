using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace PDS.PDC.Services
{
    internal class Conect_FB
    {
        public static FirebaseClient FirebaseClient = new FirebaseClient("https://planta-de-cerveza-default-rtdb.firebaseio.com/");
    }
}
