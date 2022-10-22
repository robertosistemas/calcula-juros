namespace CalculaJuros.Web.Services
{
    public interface ICalculadoraHttpService
    {
        Task<string> CalcularJurosAsync(double valorInicial, int meses);
    }
}
