using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApi.Context; 
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoundsController : ControllerBase
    {
        private readonly AppDBContext _context;

        public RoundsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Rounds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Round>>> GetRounds()
        {
          if (_context.Rounds == null)
          {
              return NotFound();
          }
            return await _context.Rounds.ToListAsync();
        }

        // GET: api/Rounds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Round>> GetRonda(int id)
        {
          if (_context.Rounds == null)
          {
              return NotFound();
          }
            var ronda = await _context.Rounds.FindAsync(id);

            if (ronda == null)
            {
                return NotFound();
            }

            return ronda;
        }

        // PUT: api/Rounds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRonda(int id, Round ronda)
        {
            if (id != ronda.Id)
            {
                return BadRequest();
            }

            _context.Entry(ronda).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RondaExists(id))
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

        // POST: api/Rounds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Round>> PostRonda(Round ronda)
        {
            if (_context.Rounds == null)
            {
                return Problem("Entity set 'AppDBContext.Rounds' is null.");
            }

            // Asegúrate de que ronda y Id_Game no sean nulos
            if (ronda == null || ronda.Id_Game <= 0)
            {
                return BadRequest("Ronda and Id_Game are required and must be valid.");
            }

            // Busca el Game correspondiente por su ID
            var game = await _context.Games.FindAsync(ronda.Id_Game);
            if (game == null)
            {
                return NotFound($"Game with Id {ronda.Id_Game} not found.");
            }

            // Agrega la nueva ronda a la base de datos
            ronda.Game = game; // Establece el objeto Game en lugar de solo la ID
            _context.Rounds.Add(ronda);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRonda", new { id = ronda.Id }, new Round { Id = ronda.Id, Id_Game = ronda.Id_Game });
        }




        // DELETE: api/Rounds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRonda(int id)
        {
            if (_context.Rounds == null)
            {
                return NotFound();
            }
            var ronda = await _context.Rounds.FindAsync(id);
            if (ronda == null)
            {
                return NotFound();
            }

            _context.Rounds.Remove(ronda);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RondaExists(int id)
        {
            return (_context.Rounds?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
