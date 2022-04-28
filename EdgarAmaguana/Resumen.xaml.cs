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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, string cuotaI)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblNombre.Text = nombre;
            double cuotaInicial = Convert.ToDouble(cuotaI);
            double calculo = ((3000 - cuotaInicial) / 5 + (3000 * 0.05));
            calculo = calculo * 5 + cuotaInicial;
            lblCuota.Text = calculo.ToString();

        }
    }
}