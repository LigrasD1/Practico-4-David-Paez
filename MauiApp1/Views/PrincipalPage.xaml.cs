namespace MauiApp1.Views;

public partial class PrincipalPage : ContentPage
{
	public PrincipalPage()
	{
		InitializeComponent();
	}
    private void BtnSalir_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }

    private void BtAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AcercaPage());
    }
}