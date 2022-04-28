using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EdgarAmaguana
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIniciarsesion_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (usuario == "edgar2022" && contrasena == "uisrael2022")
            {
                await Navigation.PushAsync(new Registro(usuario));
            }

            else
            {
                DisplayAlert("Error!", "Credenciales no validas", "Cerrar");
            }

        }
    }
}