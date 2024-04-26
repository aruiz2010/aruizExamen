namespace aruizExamen.Vistas;

public partial class vRegistro : ContentPage
{
	public vRegistro(string usuario)
	{
		InitializeComponent();
        DisplayAlert("Alerta", "Bienvenido " + usuario, "Cerrar");
        lblUsuario.Text = "Usuario conectado " + usuario;
    }

    private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        if (sender is Entry entry)
        {
            if (!string.IsNullOrWhiteSpace(entry.Text))
            {
                if (!double.TryParse(entry.Text, out double value) || value < 0 || value > 1500)
                {
                    // Si el valor no es válido, muestra un mensaje de error y borra el texto
                    DisplayAlert("Error", "Ingrese un valor mayor a 0 y menor a 1500", "Aceptar");
                    entry.Text = "";
                }
            }
        }
    }

    private void btnCalcula_Clicked(object sender, EventArgs e)
    {
        Double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
        Double calculo = 1500 - montoInicial;
        Double cuotaMensual = calculo / 4;
        Double interes = (1500 * 4) / 100;
        Double pagoMensual = cuotaMensual + interes;

    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {

    }
}