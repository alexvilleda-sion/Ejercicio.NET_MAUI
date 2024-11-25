namespace Ejercicio_NET_MAUI.Pages;



public partial class AreaRectanguloPage : ContentPage
{
    public AreaRectanguloPage()
    {
        InitializeComponent();
    }

    private async void OnCalcularAreaClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(baseEntry.Text) || string.IsNullOrWhiteSpace(alturaEntry.Text))
        {
            await DisplayAlert("Error", "Debe ingresar valores para la base y la altura.", "OK");
            return;
        }

        if (double.TryParse(baseEntry.Text, out double baseValue) &&
            double.TryParse(alturaEntry.Text, out double altura))
        {
            double area = baseValue * altura;
            resultadoLabel.Text = $"El área del rectángulo es: {area}";
        }
        else
        {
            await DisplayAlert("Error", "Ingrese números válidos.", "OK");
        }
    }

    private void OnLimpiarClicked(object sender, EventArgs e)
    {
        baseEntry.Text = string.Empty;
        alturaEntry.Text = string.Empty;
        resultadoLabel.Text = string.Empty;
    }
}
