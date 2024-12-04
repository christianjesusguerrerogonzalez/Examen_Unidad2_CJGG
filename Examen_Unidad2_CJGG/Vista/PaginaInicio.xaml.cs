using Microsoft.Maui.Controls;

namespace Examen_Unidad2_CJGG.Vista
{
    public partial class PaginaInicio : ContentPage
    {
        public PaginaInicio()
        {
            InitializeComponent();
        }
        //Hacemos que cada boton vaya a su pagina correspondiente
        private async void OnProductosClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaProductos());
        }

        private async void OnAcercaDeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaAcercaDe());
        }

        private async void OnRegistroClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaRegistro());
        }
    }
}
