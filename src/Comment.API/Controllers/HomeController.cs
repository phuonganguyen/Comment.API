using Microsoft.AspNetCore.Mvc;

namespace Comment.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Index() => "Hello";
    }
}
