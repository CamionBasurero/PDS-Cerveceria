using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDS.PDC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIn : ContentPage
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Registro(object sender, EventArgs e)
        {
           Navigation.PushAsync(new Registro());
        }


        private void Ingresar_Usuario(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Inicio_app());
        }

        private void Recuperar_Clave(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Recuperar_Clave());
        }
    }
}