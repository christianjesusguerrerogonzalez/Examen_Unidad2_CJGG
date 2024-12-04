using Examen_Unidad2_CJGG.Modelo;

namespace Examen_Unidad2_CJGG.Vista
{
    public partial class PaginaProductoDetallado : ContentPage
    {
        public Producto Producto { get; set; }

        public PaginaProductoDetallado(Producto producto)
        {
            InitializeComponent();
            //Asignamos la imagen, nombre y descripcion de la imagen que hemos pulsado en la lista, consiguiendolo por el parametro del producto en el constructor
            imgProducto.Source = producto.imagen;
            lblNombre.Text = producto.nombre;
            lblDescripcion.Text = producto.descripcion;


        }
    }
}
