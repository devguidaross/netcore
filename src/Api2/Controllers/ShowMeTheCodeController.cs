using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        const string urlGitHub = "https://github.com/devguidaross/netcore/";

        // GET: api/ShowMeTheCode
        [HttpGet]
        public string Get()
        {
            return urlGitHub;
        }
    }
}
