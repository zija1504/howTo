using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using howTo.Models;
namespace howTo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly CommandContext _context;

        public CommandsController(CommandContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Commands>> GetAction() => _context.CommandItems;
    }
}
