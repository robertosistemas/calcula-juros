using Xunit;

namespace CalculaJuros.WebApi.Controllers;

public class ShowMeTheCodeControllerUnitTest : BaseWebApiUnitTest
{

    [Fact]
    public void Get_Quando_Executado_Retorna_Url_Fonte_Github()
    {
        //Arrange
        var calculaJurosController = new ShowMeTheCodeController();
        //Act
        var resultado = calculaJurosController.Get().Value;
        //Assert
        Assert.Equal("https://github.com/robertosistemas/CalculaJuros", resultado);
    }

}

