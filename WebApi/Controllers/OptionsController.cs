using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Context;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase
    {
        private readonly AppDBContext _context;

        public OptionsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Options
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Option>>> GetOptions()
        {
          if (_context.Options == null)
          {
              return NotFound();
          }
            return await _context.Options.ToListAsync();
        }

        // GET: api/Options/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Option>> GetOpcion(int id)
        {
          if (_context.Options == null)
          {
              return NotFound();
          }
            var opcion = await _context.Options.FindAsync(id);

            if (opcion == null)
            {
                return NotFound();
            }

            return opcion;
        }

        // PUT: api/Options/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOpcion(int id, Option opcion)
        {
            if (id != opcion.Id)
            {
                return BadRequest();
            }

            _context.Entry(opcion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OpcionExists(id))
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

        // POST: api/Options
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Option>> PostOpcion(Option opcion)
        {
          if (_context.Options == null)
          {
              return Problem("Entity set 'AppDBContext.Options'  is null.");
          }
            _context.Options.Add(opcion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOpcion", new { id = opcion.Id }, opcion);
        }

        // DELETE: api/Options/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOpcion(int id)
        {
            if (_context.Options == null)
            {
                return NotFound();
            }
            var opcion = await _context.Options.FindAsync(id);
            if (opcion == null)
            {
                return NotFound();
            }

            _context.Options.Remove(opcion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OpcionExists(int id)
        {
            return (_context.Options?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
