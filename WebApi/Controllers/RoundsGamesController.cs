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
    public class RoundsGamesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public RoundsGamesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/RoundsGames
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoundsGames>>> GetRoundsGames()
        {
          if (_context.RoundsGames == null)
          {
              return NotFound();
          }
            return await _context.RoundsGames.ToListAsync();
        }

        // GET: api/RoundsGames/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoundsGames>> GetRoundsGames(int id)
        {
          if (_context.RoundsGames == null)
          {
              return NotFound();
          }
            var RoundsGames = await _context.RoundsGames.FindAsync(id);

            if (RoundsGames == null)
            {
                return NotFound();
            }

            return RoundsGames;
        }

        // PUT: api/RoundsGames/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoundsGames(int id, RoundsGames RoundsGames)
        {
            if (id != RoundsGames.Id)
            {
                return BadRequest();
            }

            _context.Entry(RoundsGames).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoundsGamesExists(id))
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

        // POST: api/RoundsGames
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
public async Task<ActionResult<RoundsGames>> PostRoundsGames(RoundsGames RoundsGames)
{
    if (_context.RoundsGames == null)
    {
        return Problem("Entity set 'AppDBContext.RoundsGames' is null.");
    }

    // Validar que el Id_Options existe
    if (!_context.Options.Any(o => o.Id == RoundsGames.Id_Options))
    {
        return BadRequest("El Id_Options proporcionado no existe.");
    }

    // Agregar el nuevo objeto a la base de datos
    _context.RoundsGames.Add(RoundsGames);
    await _context.SaveChangesAsync();

    return CreatedAtAction("GetRoundsGames", new { id = RoundsGames.Id }, RoundsGames);
}

        // DELETE: api/RoundsGames/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoundsGames(int id)
        {
            if (_context.RoundsGames == null)
            {
                return NotFound();
            }
            var RoundsGames = await _context.RoundsGames.FindAsync(id);
            if (RoundsGames == null)
            {
                return NotFound();
            }

            _context.RoundsGames.Remove(RoundsGames);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoundsGamesExists(int id)
        {
            return (_context.RoundsGames?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
