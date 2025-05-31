namespace CadastroEventos.Views;

public partial class ResumoPage : ContentPage
{
    public ResumoPage(Evento evento)
    {
        InitializeComponent();
        BindingContext = evento; 
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}