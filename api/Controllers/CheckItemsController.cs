using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckItemsController : ControllerBase
    {
        private readonly CheckContext _context;

        public CheckItemsController(CheckContext context)
        {
            _context = context;
        }

        // GET: api/CheckItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CheckItem>>> GetCheckItems()
        {
            return await _context.CheckItems.ToListAsync();
        }

        // GET: api/CheckItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CheckItem>> GetCheckItem(long id)
        {
            var checkItem = await _context.CheckItems.FindAsync(id);

            if (checkItem == null)
            {
                return NotFound();
            }

            return checkItem;
        }

        // PUT: api/CheckItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCheckItem(long id, CheckItem checkItem)
        {
            if (id != checkItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(checkItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CheckItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CheckItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CheckItem>> PostCheckItem(CheckItem checkItem)
        {
            _context.CheckItems.Add(checkItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCheckItem", new { id = checkItem.Id }, checkItem);
        }

        // DELETE: api/CheckItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCheckItem(long id)
        {
            var checkItem = await _context.CheckItems.FindAsync(id);
            if (checkItem == null)
            {
                return NotFound();
            }

            _context.CheckItems.Remove(checkItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CheckItemExists(long id)
        {
            return _context.CheckItems.Any(e => e.Id == id);
        }
    }
}
