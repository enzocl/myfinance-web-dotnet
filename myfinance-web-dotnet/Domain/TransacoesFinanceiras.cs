namespace myfinance_web_dotnet.Domain
{
    public class TransacoesFinanceiras
    {
        public int Id {get; set;}
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public string Historico { get; set; }
        public string Tipo { get; set; }
        public int PlanoContaId { get; set; }
        public PlanoContas PlanoContas { get; set; }
    }
}