using Api1.Controllers;
using Xunit;

namespace Api1Test
{
    public class TaxaJurosControllerTest
    {
        TaxaJurosController taxaJurosController;

        public TaxaJurosControllerTest()
        {
            taxaJurosController = new TaxaJurosController();
        }

        [Fact]
        public void TaxaJurosTeste()
        {
            var okResult = taxaJurosController.Get();
            Assert.Equal(1, okResult);
        }
    }
}
