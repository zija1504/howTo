using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace howTo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAction() => new string[] { "this", "is", "hard", "coded" };
    }
}
