namespace CadastroEventos.Views
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; } = DateTime.Today;
        public DateTime DataTermino { get; set; } = DateTime.Today.AddDays(1);
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }


        
        public int DuracaoDias => (DataTermino - DataInicio).Days + 1;

      
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;
    }
}