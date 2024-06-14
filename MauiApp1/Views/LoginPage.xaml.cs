namespace MauiApp1.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    private void BtnIniciar_Clicked(object sender, EventArgs e)
    {
        if (entNomUsuario.Text == "Alumno" && entPassword.Text == "1234")
        {
            entPassword.Text = string.Empty;
            entNomUsuario.Text = string.Empty;
            Navigation.PushAsync(new PrincipalPage());
        }
        else
        {
            entPassword.Text = string.Empty;
            entNomUsuario.Text = string.Empty;
            DisplayAlert("Atención", "las credenciales ingresadas no son válidas", "OK");
        }

    }
}