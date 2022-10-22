using Xunit;

namespace CalculaJuros.Web.Services
{
    public class CalculadoraHttpServiceUnitTest: BaseWebUnitTest
    {

        [Fact]
        public async Task Quando_Executado_Retorna_Calculo_Juros_Composto()
        {
            //Arrange
            var srv = new CalculadoraHttpServiceFake();
            //Act
            var item = await srv.CalcularJurosAsync(100, 5);
            //Assert
            Assert.Equal("105,10", item);
        }

    }

}
