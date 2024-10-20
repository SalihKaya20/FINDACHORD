using FINDACHORD.Data;
using FINDACHORD.DTO;
using FINDACHORD.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FINDACHORD.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class ChordController : ControllerBase
    {


        private readonly DataContext _context ;

        public ChordController(DataContext context)
        {
            _context =context;
        }





        [HttpGet(Name = "GetChords")]
        public async Task<IActionResult> GetChords()
        {
            var chords = await _context.Chords.Select(c => new ChordDTO{
                ChordId = c.ChordId,
                ChordName = c.ChordName,
            })
            .ToListAsync();


            if(!chords.Any())
            {
                return NotFound("Chords NotFound");
            }

            return Ok(chords);
        }



        [HttpGet("{id}", Name = "GetChord")]
        public async Task<IActionResult> GetChord(int id)
        {
   
            var chord = await _context.Chords
                .Where(c => c.ChordId == id)
                .Select(c => new ChordDTO
            {
                ChordId = c.ChordId,
                ChordName = c.ChordName
            })
                .FirstOrDefaultAsync();

        
            if (chord == null)
            {
                return NotFound("Chord NotFound");
            }

            return Ok(chord);   

        }
    }
}