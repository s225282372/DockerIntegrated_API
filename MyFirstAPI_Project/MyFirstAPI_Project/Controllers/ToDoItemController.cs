using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstAPI_Project.Infrastructure;
using MyFirstAPI_Project.Infrastructure.Models;

namespace MyFirstAPI_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoItemController: ControllerBase
    {
        private readonly DBContext _context;

        public ToDoItemController(DBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoItem>>> GetToDoItems()
        {
            return await _context.ToDoItems.ToListAsync();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ToDoItem>> GetToDoItem(int Id)
        {
            var toDoItem = await _context.ToDoItems.FindAsync(Id);


            if (toDoItem == null)
            {
                return NotFound();
            }
            return toDoItem;
        }

        [HttpPost]
        public async Task<ActionResult<ToDoItem>> PostToDoItem(ToDoItem toDoItem)
        {
            _context.ToDoItems.Add(toDoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetToDoItem", new { id = toDoItem.Id }, toDoItem);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteToDoItem(int Id)
        {
            var toDoItem = await _context.ToDoItems.FindAsync(Id);


            if (toDoItem == null)
            {
                return NotFound();
            }

            _context.ToDoItems.Remove(toDoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
