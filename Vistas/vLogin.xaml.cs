namespace aruizExamen.Vistas;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        String usuario = "uisrael";
        String contrase�a = "123";
        if (txtUsuario.Text == usuario && txtContrase�a.Text == contrase�a)
        {
            Navigation.PushAsync(new vRegistro(usuario));
        }
        else { 
             DisplayAlert("Alerta", "Usuario/Contrase�a inocrectos", "Cerrar");
        }
    }

    private void btnAcercade_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vistas.vAcercade());
    }
}