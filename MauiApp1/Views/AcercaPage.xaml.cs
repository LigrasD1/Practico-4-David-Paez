namespace MauiApp1.Views;

public partial class AcercaPage : ContentPage
{
	public AcercaPage()
	{
		InitializeComponent();
	}

    private async void BtnCall_Clicked(object sender, EventArgs e)
    {
        try
        {
            var phoneNumber = "2954 558822"; 

            var uri = new Uri($"tel:{phoneNumber}");

            await Launcher.OpenAsync(uri);
        }
        catch (Exception ex)
        {
            
            await DisplayAlert("Error", $"No se pudo abrir la aplicación de teléfono: {ex.Message}", "OK");
        }
    }

    private async void BtnEmail_Clicked(object sender, EventArgs e)
    {

        try
        {
            var email = "ejemplo@correo.com"; 
            var subject = "Asunto del correo";
            var body = "Cuerpo del correo";

            var uri = new Uri($"mailto:{email}?subject={Uri.EscapeDataString(subject)}&body={Uri.EscapeDataString(body)}");

            await Launcher.OpenAsync(uri);
        }
        catch (Exception ex)
        {
            
            await DisplayAlert("Error", $"No se pudo abrir la aplicación de correo: {ex.Message}", "OK");
        }
    }

    private void BtnSalir_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();

    }

    private void BtnVolver_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();

    }
}