using Api2.Controllers;
using System.Threading.Tasks;
using Api2.Repository;
using Xunit;

namespace Api1Test
{
    public class CalculaJurosControllerTest
    {
        CalculaJurosController _calculaJurosController;

        public CalculaJurosControllerTest()
        {
            this._calculaJurosController = new CalculaJurosController(new JurosRepository());
        }

        [Fact]
        public async void CalculaJurosTeste()
        {
            var okResult = await _calculaJurosController.GetAsync(100,5);
            Assert.IsType<string>(okResult);
            Assert.Equal("105,10", okResult);
        }

    }
}
