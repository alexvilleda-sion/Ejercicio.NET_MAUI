namespace Ejercicio_NET_MAUI.Pages;

public partial class AreaCirculoPage : ContentPage
{
    public AreaCirculoPage()
    {
        InitializeComponent();
    }

    private async void OnCalcularAreaClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(radioEntry.Text))
        {
            await DisplayAlert("Error", "Debe ingresar el valor del radio.", "OK");
            return;
        }

        if (double.TryParse(radioEntry.Text, out double radio))
        {
            double area = Math.PI * radio * radio;
            resultadoLabel.Text = $"El área del círculo es: {area:F2}";
        }
        else
        {
            await DisplayAlert("Error", "Ingrese un número válido.", "OK");
        }
    }

    private void OnLimpiarClicked(object sender, EventArgs e)
    {
        radioEntry.Text = string.Empty;
        resultadoLabel.Text = string.Empty;
    }
}
