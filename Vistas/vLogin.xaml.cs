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
        String contraseña = "123";
        if (txtUsuario.Text == usuario && txtContraseña.Text == contraseña)
        {
            Navigation.PushAsync(new vRegistro(usuario));
        }
        else { 
             DisplayAlert("Alerta", "Usuario/Contraseña inocrectos", "Cerrar");
        }
    }

    private void btnAcercade_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Vistas.vAcercade());
    }
}