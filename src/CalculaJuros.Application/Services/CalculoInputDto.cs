namespace CalculaJuros.Application.Services
{
    public class CalculoInputDto
    {
        public double ValorInicial { get; set; }
        public int Meses { get; set; }

        public CalculoInputDto(double valorInicial, int meses)
        {
            ValorInicial = valorInicial;
            Meses = meses;
        }
    }
}
