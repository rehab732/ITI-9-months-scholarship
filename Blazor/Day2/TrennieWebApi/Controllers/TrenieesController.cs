using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TranieeLibrary;
using TrennieWebApi.Models;

namespace TrennieWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrenieesController : ControllerBase
    {
        private readonly TranieeDBContext _context;

        public TrenieesController(TranieeDBContext context)
        {
            _context = context;
        }

        // GET: api/Treniees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Treniee>>> GetTreniees()
        {
          if (_context.Treniees == null)
          {
              return NotFound();
          }
            return await _context.Treniees.ToListAsync();
        }

        // GET: api/Treniees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Treniee>> GetTreniee(int id)
        {
          if (_context.Treniees == null)
          {
              return NotFound();
          }
            var treniee = await _context.Treniees.FindAsync(id);

            if (treniee == null)
            {
                return NotFound();
            }

            return treniee;
        }

        // PUT: api/Treniees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTreniee(int id, Treniee treniee)
        {
            if (id != treniee.TraineeId)
            {
                return BadRequest();
            }

            _context.Entry(treniee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrenieeExists(id))
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

        // POST: api/Treniees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Treniee>> PostTreniee(Treniee treniee)
        {
          if (_context.Treniees == null)
          {
              return Problem("Entity set 'TranieeDBContext.Treniees'  is null.");
          }
            _context.Treniees.Add(treniee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTreniee", new { id = treniee.TraineeId }, treniee);
        }

        // DELETE: api/Treniees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTreniee(int id)
        {
            if (_context.Treniees == null)
            {
                return NotFound();
            }
            var treniee = await _context.Treniees.FindAsync(id);
            if (treniee == null)
            {
                return NotFound();
            }

            _context.Treniees.Remove(treniee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TrenieeExists(int id)
        {
            return (_context.Treniees?.Any(e => e.TraineeId == id)).GetValueOrDefault();
        }
    }
}
