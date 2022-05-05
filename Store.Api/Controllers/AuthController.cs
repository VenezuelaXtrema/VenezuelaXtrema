using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Store.Api.Controllers
{
    [AllowAnonymous]
    public class AuthController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
