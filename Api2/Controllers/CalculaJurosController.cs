using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Api2.Repository;

namespace Api2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        private readonly IJurosRepository _jurosRepository;

        public CalculaJurosController(IJurosRepository jurosRepository)
        {
            _jurosRepository = jurosRepository;
        }


        // GET: api/CalculaJuros
        [HttpGet]
        public async Task<string> GetAsync(double valorInicial, int meses)
        {
           return await _jurosRepository.CalculaJuros(valorInicial, meses);
        }
    }
}
