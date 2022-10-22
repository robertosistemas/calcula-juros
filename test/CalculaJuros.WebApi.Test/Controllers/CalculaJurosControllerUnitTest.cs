using CalculaJuros.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace CalculaJuros.WebApi.Controllers;

public class CalculaJurosControllerUnitTest : BaseWebApiUnitTest
{

    [Fact]
    public void Get_Quando_Executado_Retorna_Calculo_Juros_Composto()
    {
        //Arrange
        var calculadoraFinanceiraService = serviceProvider.GetService<ICalculadoraFinanceiraService>();
        var calculaJurosController = new CalculaJurosController(calculadoraFinanceiraService);
        //Act
        var resultado = calculaJurosController.Get(100, 5).Value;
        //Assert
        Assert.Equal("105,10", resultado);
    }

}
