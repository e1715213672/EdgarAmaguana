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
    public partial class Registro : ContentPage
    {
  
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario.ToString();
            
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                
                string nombre = txtNombre.ToString();
                double cuota = Convert.ToDouble(txtCuota.Text);
                if (cuota<3000) {
                    double calculo = (3000 - cuota)/5 + (3000 * 0.05);
                    lblPagoMensual.Text = calculo.ToString();
                }

                else {
                    DisplayAlert("ERROR","La cuota inicial debe ser menor a 3000","Cerrar");
                }


            }
            catch (Exception ex)
            {

                DisplayAlert("ERROR", ex.Message, "Cerrar"); ;
            }

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
                

            if (txtNombre.Text == "" || txtCuota.Text == "")
            {
                DisplayAlert("Error!", "Ingrese los datos solicitados", "Cerrar");
            }

            else
            {
                DisplayAlert("Notificación", "Elemento guardado con exito", "Cerrar");
                await Navigation.PushAsync(new Resumen(lblUsuario.Text, txtNombre.Text, txtCuota.Text));
            }

        }
    }
}