namespace _3716370Practica13;

public partial class Principal : ContentPage
{
	public Principal()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Area());
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Brocha());
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Empleado());
    }

    private async  void Button_Clicked_4(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Distancia());
    }
}