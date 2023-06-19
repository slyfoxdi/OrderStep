using Microsoft.AspNetCore.Mvc;
using OrderStep.WebApi.Model;

namespace OrderStep.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        public AuthController()
        {

        }


        [HttpGet(nameof(Authentification))]
        public async Task<Client> Authentification(string login, string password)
        {
            return new Client();
        }
    }
}
