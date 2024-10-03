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
    public class GamesController : ControllerBase
    {
        private readonly AppDBContext _context;

        public GamesController(AppDBContext context)
        {
            _context = context;
        }

            [HttpGet("info")]
            public async Task<ActionResult<IEnumerable<Game>>> GetInfo()
            {

                if (_context.Games == null)
                {
                    return NotFound();
                }
            List<Game> gamesWithDetails = await _context.Games
.Include(g => g.Rounds) // Cargar Rounds
    .ThenInclude(r => r.RoundsGames) // Cargar RoundsGames de cada Round
        .ThenInclude(rg => rg.Player) // Cargar Player de cada RoundsGames
.Include(g => g.Rounds)
    .ThenInclude(r => r.RoundsGames)
        .ThenInclude(rg => rg.Option) // Cargar Option de cada RoundsGames
.ToListAsync();

            return gamesWithDetails;
            }


        // GET: api/Games
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetGames()
        {
          if (_context.Games == null)
          {
              return NotFound();
          }
            return await _context.Games.ToListAsync();
        }

        // GET: api/Games/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetJuego(int id)
        {
          if (_context.Games == null)
          {
              return NotFound();
          }
            var juego = await _context.Games.FindAsync(id);

            if (juego == null)
            {
                return NotFound();
            }

            return juego;
        }

        // PUT: api/Games/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJuego(int id, Game juego)
        {
            if (id != juego.Id)
            {
                return BadRequest();
            }

            _context.Entry(juego).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JuegoExists(id))
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

        // POST: api/Games
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Game>> PostJuego(Game juego)
        {
          if (_context.Games == null)
          {
              return Problem("Entity set 'AppDBContext.Games'  is null.");
          }
            _context.Games.Add(juego);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJuego", new { id = juego.Id }, juego);
        }

        // DELETE: api/Games/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJuego(int id)
        {
            if (_context.Games == null)
            {
                return NotFound();
            }
            var juego = await _context.Games.FindAsync(id);
            if (juego == null)
            {
                return NotFound();
            }

            _context.Games.Remove(juego);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JuegoExists(int id)
        {
            return (_context.Games?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
