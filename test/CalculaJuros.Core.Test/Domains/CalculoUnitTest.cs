using Xunit;

namespace CalculaJuros.Core.Domains;

public class CalculoUnitTest : BaseCoreUnitTest
{
    [Fact]
    public void Quando_Executado_Retorna_Calculo_Juros_Composto()
    {
        //Arrange
        Calculo calculo = new Calculo(100, 5);
        //Act
        calculo.Calcula(0.01);
        //Assert
        Assert.Equal("105,10", calculo.ToString());
    }

}
