namespace MauiAppHotelLayout.Views;

public partial class ContratacaoHospetagem : ContentPage
{
	public ContratacaoHospetagem()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobreHospedagem());
    }
}