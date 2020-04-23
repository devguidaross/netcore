using Microsoft.AspNetCore.Mvc;

namespace Api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        const double taxaJuros = 1;

        // GET: api/TaxaJuros
        [HttpGet]
        public double Get()
        {
            return taxaJuros;
        }
    }
}
