namespace CalculaJuros.Application.Services
{
    public interface ICalculadoraFinanceiraService
    {
        CalculoOutputDto CalculaJurosComposto(CalculoInputDto calculoInputDto);
    }
}
