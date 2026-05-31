namespace MauiAppHotelLayout.Views;

public partial class ContratacaoHospetagem : ContentPage
{
    App PropriedadesApp;
    

    public ContratacaoHospetagem()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(6);

        dtpck_checkout.MinimumDate = dtpck_checkin.MinimumDate;
        dtpck_checkout.MaximumDate = dtpck_checkin.MaximumDate;
    }
    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}