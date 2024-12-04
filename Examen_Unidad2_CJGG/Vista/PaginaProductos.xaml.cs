
using Examen_Unidad2_CJGG.Modelo;

namespace Examen_Unidad2_CJGG.Vista
{
    public partial class PaginaProductos : ContentPage
    {
        //Hacemos una lista para productos
        public List<Producto> Productos { get; set; }

        public PaginaProductos()
        {
            InitializeComponent();
            //La inicializamos
            Productos = new List<Producto>
            {
                //A�adimos los datos
                new Producto { imagen = "imagenauriculares.jpg", nombre = "Auriculares Inal�mbricos", descripcion = "Los auriculares inal�mbricos son simplemente aquellos que no requieren un cable f�sico para conectarse a la fuente de audio" },
                new Producto { imagen = "imagensmartwatch.jpg", nombre = "Smartwatch Deportivo", descripcion = "Est�n dise�ados para hacer frente a las exigencias de la actividad f�sica" },
                new Producto { imagen = "imagencamaradigital.jpg", nombre = "C�mara Digital 4K", descripcion = "Una c�mara digital es una c�mara que produce im�genes digitales que pueden almacenarse en una computadora, mostrarse en una pantalla e imprimirse." },
                new Producto { imagen = "imagenportatilgaming.jpg", nombre = "Port�til Gaming", descripcion = "Se trata de port�tiles con un gasto de energ�a mayor ya que son equipos m�s potentes." },
                new Producto { imagen = "altavocesbluetooth.jpg", nombre = "Altavoces Bluetooth Port�tiles", descripcion = "Son altavoces que se conectan a tus dispositivos a trav�s de Bluetooth." }
            };

            BindingContext = this;
        }

        //Hacemos una funcion para cuando pulsemos la imagen, nos de los datos del producto que hemos pulsado y naveguemos a la pagina con los datos correspondientes.
        private async void OnImageTapped(object sender, EventArgs e)
        {
            var tappedImage = sender as Image;
            if (tappedImage == null)
                return;

            var producto = tappedImage.BindingContext as Producto;
            if (producto == null)
                return;

            await Navigation.PushAsync(new PaginaProductoDetallado(producto));
        }
    }
}
