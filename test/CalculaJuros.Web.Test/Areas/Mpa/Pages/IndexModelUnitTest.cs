using CalculaJuros.Web.Services;
using Xunit;

namespace CalculaJuros.Web.Areas.Mpa.Pages;

public class IndexModelUnitTest: BaseWebUnitTest
{
    [Fact]
    public async Task Quando_Executado_Retorna_Calculo_Juros_Composto()
    {
        //Arrange
        var srv = new CalculadoraHttpServiceFake();
        var pageModel = new IndexModel(srv);
        //Código da competição
        pageModel.Calculo = new ViewModels.CalculoViewModel();
        pageModel.Calculo.ValorInicial = 100;
        pageModel.Calculo.Meses = 5;
        //Act
        await pageModel.OnPostAsync();
        //Assert
        Assert.Equal("105,10", pageModel.Calculo.Resultado);
    }

}
