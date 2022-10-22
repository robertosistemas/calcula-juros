using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace CalculaJuros.Core.Domains;

public class CalculadoraServiceUnitTest : BaseCoreUnitTest
{
    [Fact]
    public void Quando_Executado_Retorna_Calculo_Juros_Composto()
    {
        //Arrange
        var calculadoraService = serviceProvider.GetService<ICalculadoraService>();
        Calculo calculo = new Calculo(100, 5);
        //Act
        calculo = calculadoraService.CalculaJurosComposto(calculo);
        //Assert
        Assert.Equal("105,10", calculo.ToString());
    }

}
