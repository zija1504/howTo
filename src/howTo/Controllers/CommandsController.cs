using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            //random comment
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Commands>> GetCommandItems() => _context.CommandItems;
        [HttpGet("{id}")]
        public ActionResult<Commands> GetCommandItem(int id)
        {
            var commandItem = _context.CommandItems.Find(id);
            if (commandItem is null)
            {
                return NotFound();
            }
            return commandItem;
        }

        public ActionResult<Commands> PostCommandItem(Commands command)
        {
            _context.CommandItems.Add(command);
            try
            {
                _context.SaveChanges();
            }
            catch
            {
                return BadRequest();
            }
            return CreatedAtAction("GetCommandItem", new Commands { Id = command.Id }, command);
        }
        //PUT: api/commands/{Id}
        [HttpPut("{id}")]
        public ActionResult PutCommandItem(int id, Commands command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
            _context.Entry(command).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }
        //Delete api/commands/{Id}

        [HttpDelete("{id}")]
        public ActionResult<Commands> DeleteCommandItem(int id)
        {
            var commandItem = _context.CommandItems.Find(id);
            if (commandItem is null)
                return NotFound();
            _context.CommandItems.Remove(commandItem);
            _context.SaveChanges();

            return commandItem;
        }
    }
}
