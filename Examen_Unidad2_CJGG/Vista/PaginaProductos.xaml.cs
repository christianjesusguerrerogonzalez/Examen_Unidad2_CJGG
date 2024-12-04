
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
                //Añadimos los datos
                new Producto { imagen = "imagenauriculares.jpg", nombre = "Auriculares Inalámbricos", descripcion = "Los auriculares inalámbricos son simplemente aquellos que no requieren un cable físico para conectarse a la fuente de audio" },
                new Producto { imagen = "imagensmartwatch.jpg", nombre = "Smartwatch Deportivo", descripcion = "Están diseñados para hacer frente a las exigencias de la actividad física" },
                new Producto { imagen = "imagencamaradigital.jpg", nombre = "Cámara Digital 4K", descripcion = "Una cámara digital es una cámara que produce imágenes digitales que pueden almacenarse en una computadora, mostrarse en una pantalla e imprimirse." },
                new Producto { imagen = "imagenportatilgaming.jpg", nombre = "Portátil Gaming", descripcion = "Se trata de portátiles con un gasto de energía mayor ya que son equipos más potentes." },
                new Producto { imagen = "altavocesbluetooth.jpg", nombre = "Altavoces Bluetooth Portátiles", descripcion = "Son altavoces que se conectan a tus dispositivos a través de Bluetooth." }
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
