namespace Examen_Unidad2_CJGG.Vista;

public partial class PaginaRegistro : ContentPage
{
    public PaginaRegistro()
    {
        InitializeComponent();
    }

    private void OnRegistrarClicked(object sender, EventArgs e)
    //Si los datos no estan completados, nos da una alerta para el error.

    {
        if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCorreo.Text) ||
            string.IsNullOrEmpty(txtContrase�a.Text) || string.IsNullOrEmpty(txtConfirmarContrase�a.Text))
        {
            DisplayAlert("Error", "Rellena todos los campos", "Confirmar");
            return;
        }
        //Si el correo no contiene el @gmail/hotmail o .com/.es, da error
        if (!txtCorreo.Text.Contains("@gmail") && !txtCorreo.Text.Contains("@hotmail") || !txtCorreo.Text.Contains(".com") && !txtCorreo.Text.Contains(".es"))
        {
            DisplayAlert("Error", "A�ade un correo electr�nico v�lido", "Confirmar");
            return;
        }
        //Si la contrase�a no tiene 8 letras o mas, da error.
        if (txtContrase�a.Text.Length < 8)
        {
            DisplayAlert("Error", "La contrase�a debe tener al menos 8 letras", "Confirmar");
            return;
        }
        //Si la confirmacion no es la misma, da error
        if (txtContrase�a.Text != txtConfirmarContrase�a.Text)
        {
            DisplayAlert("Error", "Las contrase�as no son iguales", "Confirmar");
            return;
        }
        //Si todo funciona, da alerta de que se ha completado
        DisplayAlert("Exito", "Se ha completado el registro", "Confirmar");
    }

    private void OnLimpiarClicked(object sender, EventArgs e)
    {
        //Hcemos que todos los strings se vacien al pulsar limpiar
        txtNombre.Text = string.Empty;
        txtCorreo.Text = string.Empty;
        txtContrase�a.Text = string.Empty;
        txtConfirmarContrase�a.Text = string.Empty;
    }
}
