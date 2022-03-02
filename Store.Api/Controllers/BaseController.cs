using Microsoft.AspNetCore.Mvc;

namespace Store.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/{version:apiVersion}/[controller]")]
    public class BaseController : ControllerBase
    {

    }
}
