using Xunit;

namespace CalculaJuros.Web.Areas.Spa.Pages
{
    public class IndexModelUnitTest: BaseWebUnitTest
    {
        [Fact]
        public void Quando_Executado_cria_instancia_classe_IndexModel()
        {
            //Arrange
            var pageModel = new IndexModel();
            //Act
            var item = pageModel;
            //Assert
            Assert.NotNull(item);
        }

    }
}
