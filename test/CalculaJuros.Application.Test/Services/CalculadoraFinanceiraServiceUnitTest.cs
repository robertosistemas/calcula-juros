using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace CalculaJuros.Application.Services;

public class CalculadoraFinanceiraServiceUnitTest: BaseApplicationUnitTest
{
    [Fact]
    public void Quando_Executado_Retorna_Calculo_Juros_Composto()
    {
        //Arrange
        var calculadoraFinanceiraService = serviceProvider.GetService<ICalculadoraFinanceiraService>();
        var calculoInputDto = new CalculoInputDto(100, 5);
        //Act
        var calculoOutputDto = calculadoraFinanceiraService.CalculaJurosComposto(calculoInputDto);
        //Assert
        Assert.Equal("105,10", calculoOutputDto.ToString());
    }

}
