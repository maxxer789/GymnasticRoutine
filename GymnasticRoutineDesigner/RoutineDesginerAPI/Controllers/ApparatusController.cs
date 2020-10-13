using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAcces.Contexts;
using DataAcces.DTOs;

namespace RoutineDesginerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApparatusController : ControllerBase
    {
        private readonly ApparatusContext _context;

        public ApparatusController(ApparatusContext context)
        {
            _context = context;
        }

        // GET: api/Apparatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApparatusDTO>>> GetApparatus()
        {
            return await _context.Apparatus.ToListAsync();
        }

        // GET: api/Apparatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApparatusDTO>> GetApparatusDTO(int id)
        {
            var apparatusDTO = await _context.Apparatus.FindAsync(id);

            if (apparatusDTO == null)
            {
                return NotFound();
            }

            return apparatusDTO;
        }

        // PUT: api/Apparatus/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApparatusDTO(int id, ApparatusDTO apparatusDTO)
        {
            if (id != apparatusDTO.Id)
            {
                return BadRequest();
            }

            _context.Entry(apparatusDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApparatusDTOExists(id))
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

        // POST: api/Apparatus
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ApparatusDTO>> PostApparatusDTO(ApparatusDTO apparatusDTO)
        {
            _context.Apparatus.Add(apparatusDTO);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApparatusDTO", new { id = apparatusDTO.Id }, apparatusDTO);
        }

        // DELETE: api/Apparatus/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApparatusDTO>> DeleteApparatusDTO(int id)
        {
            var apparatusDTO = await _context.Apparatus.FindAsync(id);
            if (apparatusDTO == null)
            {
                return NotFound();
            }

            _context.Apparatus.Remove(apparatusDTO);
            await _context.SaveChangesAsync();

            return apparatusDTO;
        }

        private bool ApparatusDTOExists(int id)
        {
            return _context.Apparatus.Any(e => e.Id == id);
        }
    }
}
