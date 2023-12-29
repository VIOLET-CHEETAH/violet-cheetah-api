using Microsoft.AspNetCore.Mvc;
using Violet.Cheetah.Domain.Catalog;

namespace Violet.Cheetah.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("Hello world.");
        }
    }
}
