using Microsoft.AspNetCore.Mvc;
namespace RecordShop.Controllers
{
    public class AuthController: ControllerBase

    {
        private readonly IConfiguration _configuration;
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
