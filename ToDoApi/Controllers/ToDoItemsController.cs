using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoApi.Models;

namespace ToDoApi.Controllers
{
    [Route("api/ToDoItems")]
    [ApiController]
    public class ToDoItemsController : ControllerBase
    {
        private readonly ToDoContext _context;

        public ToDoItemsController(ToDoContext context)
        {
            _context = context;
        }

        // GET: api/ToDoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoItemDTO>>> GetTodoItems()
        {
            return await _context.TodoItems.Select(x => ItemToDTO(x)).ToListAsync();
        }

        // GET: api/ToDoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoItemDTO>> GetToDoItem(long id)
        {
            var toDoItemDTO = await _context.TodoItems
                .Where(x => x.Id == id)
                .Select(x => ItemToDTO(x))
                .SingleAsync();

            if (toDoItemDTO == null)
            {
                return NotFound();
            }

            return toDoItemDTO;
        }

        // PUT: api/ToDoItems/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateToDoItem(long id, ToDoItemDTO toDoItemDTO)
        {
            if (id != toDoItemDTO.Id)
            {
                return BadRequest();
            }

            var toDoItem = await _context.TodoItems.FindAsync(id);
            if (toDoItem == null)
            {
                return NotFound();
            }

            toDoItem.Name = toDoItemDTO.Name;
            toDoItem.isComplete = toDoItemDTO.IsComplete;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!ToDoItemExists(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        // POST: api/ToDoItems
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ToDoItem>> CreateToDoItem(ToDoItemDTO toDoItemDTO)
        {
            var toDoItem = new ToDoItem()
            {
                isComplete = toDoItemDTO.IsComplete,
                Name = toDoItemDTO.Name
            };

            _context.TodoItems.Add(toDoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetToDoItem),
                new {id = toDoItem.Id},
                ItemToDTO(toDoItem));
        }

        // DELETE: api/ToDoItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ToDoItem>> DeleteToDoItem(long id)
        {
            var toDoItem = await _context.TodoItems.FindAsync(id);
            if (toDoItem == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(toDoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ToDoItemExists(long id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }

        private static ToDoItemDTO ItemToDTO(ToDoItem toDoItem) =>
            new ToDoItemDTO()
            {
                Id = toDoItem.Id,
                Name = toDoItem.Name,
                IsComplete = toDoItem.isComplete
            };
    }
}
