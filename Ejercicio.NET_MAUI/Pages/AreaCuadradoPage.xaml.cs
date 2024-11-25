namespace Ejercicio_NET_MAUI.Pages;

public partial class AreaCuadradoPage : ContentPage
{
    public AreaCuadradoPage()
    {
        InitializeComponent();
    }

    private async void OnCalcularAreaClicked(object sender, EventArgs e)
    {
        // Validar que el campo no esté vacío
        if (string.IsNullOrWhiteSpace(ladoEntry.Text))
        {
            await DisplayAlert("Error", "Debe ingresar el valor del lado.", "OK");
            return;
        }

        // Intentar convertir a número
        if (double.TryParse(ladoEntry.Text, out double lado))
        {
            // Calcular el área y mostrar el resultado
            double area = lado * lado;
            resultadoLabel.Text = $"El área del cuadrado es: {area:F2}";
        }
        else
        {
            // Mostrar mensaje de error si el valor no es válido
            await DisplayAlert("Error", "Ingrese un número válido.", "OK");
        }
    }

    private void OnLimpiarClicked(object sender, EventArgs e)
    {
        // Limpiar los campos
        ladoEntry.Text = string.Empty;
        resultadoLabel.Text = string.Empty;
    }
}
