namespace CadastroEventos.Views;

public partial class CadastroEventos : ContentPage
{
    public Evento NovoEvento{ get; set; }
	public CadastroEventos()
	{
		InitializeComponent();
        NovoEvento = new Evento();
        BindingContext = NovoEvento;
    }

    private async void OnSalvarClicked(object sender, EventArgs e)
    {
     
        if (string.IsNullOrWhiteSpace(NovoEvento.Nome))
        {
            await DisplayAlert("Erro", "Digite o nome do evento", "OK");
            return;
        }

        if (NovoEvento.DataTermino < NovoEvento.DataInicio)
        {
            await DisplayAlert("Erro", "A data de término não pode ser antes do início", "OK");
            return;
        }
        if (NovoEvento.NumeroParticipantes <= 0)
        {
            await DisplayAlert("Erro", "O número de participantes deve ser maior que zero", "OK");
            return;
        }
        if (NovoEvento.CustoPorParticipante < 0)
        {
            await DisplayAlert("Erro", "O custo por participante não pode ser negativo", "OK");
            return;
        }
        if (string.IsNullOrWhiteSpace(NovoEvento.Local))
        {
            await DisplayAlert("Erro", "Digite o local do evento", "OK");
            return;
        }
        if (NovoEvento.DataInicio < DateTime.Today)
        {
            await DisplayAlert("Erro", "A data de início não pode ser no passado", "OK");
            return;
        }

        await Navigation.PushAsync(new ResumoPage(NovoEvento));
    }

    private void OnLimparClicked(object sender, EventArgs e)
    {
        NovoEvento = new Evento();
        BindingContext = NovoEvento;
    }
}