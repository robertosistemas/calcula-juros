using CalculaJuros.Core.Domains;

namespace CalculaJuros.Web.Services
{
    public class CalculadoraHttpServiceFake : ICalculadoraHttpService
    {

        public async Task<string> CalcularJurosAsync(double valorInicial, int meses)
        {
            var calculo = new Calculo(valorInicial, meses);
            calculo.Calcula(0.01);
            return await Task.FromResult(calculo.ToString());
        }
    }
}
