namespace Ejercicio_NET_MAUI.Pages;

public partial class AreaCuadradoPage : ContentPage
{
    public AreaCuadradoPage()
    {
        InitializeComponent();
    }

    private async void OnCalcularAreaClicked(object sender, EventArgs e)
    {
        // Validar que el campo no est� vac�o
        if (string.IsNullOrWhiteSpace(ladoEntry.Text))
        {
            await DisplayAlert("Error", "Debe ingresar el valor del lado.", "OK");
            return;
        }

        // Intentar convertir a n�mero
        if (double.TryParse(ladoEntry.Text, out double lado))
        {
            // Calcular el �rea y mostrar el resultado
            double area = lado * lado;
            resultadoLabel.Text = $"El �rea del cuadrado es: {area:F2}";
        }
        else
        {
            // Mostrar mensaje de error si el valor no es v�lido
            await DisplayAlert("Error", "Ingrese un n�mero v�lido.", "OK");
        }
    }

    private void OnLimpiarClicked(object sender, EventArgs e)
    {
        // Limpiar los campos
        ladoEntry.Text = string.Empty;
        resultadoLabel.Text = string.Empty;
    }
}
