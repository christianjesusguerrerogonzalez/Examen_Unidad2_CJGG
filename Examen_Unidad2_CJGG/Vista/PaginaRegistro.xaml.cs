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
            string.IsNullOrEmpty(txtContraseña.Text) || string.IsNullOrEmpty(txtConfirmarContraseña.Text))
        {
            DisplayAlert("Error", "Rellena todos los campos", "Confirmar");
            return;
        }
        //Si el correo no contiene el @gmail/hotmail o .com/.es, da error
        if (!txtCorreo.Text.Contains("@gmail") && !txtCorreo.Text.Contains("@hotmail") || !txtCorreo.Text.Contains(".com") && !txtCorreo.Text.Contains(".es"))
        {
            DisplayAlert("Error", "Añade un correo electrónico válido", "Confirmar");
            return;
        }
        //Si la contraseña no tiene 8 letras o mas, da error.
        if (txtContraseña.Text.Length < 8)
        {
            DisplayAlert("Error", "La contraseña debe tener al menos 8 letras", "Confirmar");
            return;
        }
        //Si la confirmacion no es la misma, da error
        if (txtContraseña.Text != txtConfirmarContraseña.Text)
        {
            DisplayAlert("Error", "Las contraseñas no son iguales", "Confirmar");
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
        txtContraseña.Text = string.Empty;
        txtConfirmarContraseña.Text = string.Empty;
    }
}
