using FINDACHORD.Data;
using FINDACHORD.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FINDACHORD.Controllers
{   

    [ApiController]
    [Route("api/[controller]")]
    public class ArtistController : ControllerBase
    {

        private readonly DataContext _context;

        public ArtistController(DataContext context)
        {
            _context = context;
        }




        [HttpGet( Name ="GetArtistsList")]
        public async Task<IActionResult> GetArtistsList()
        {
            var artists = await _context.Artists
            .Select(a => new ArtistListDTO
            {
                ArtistId = a.ArtistId,
                ArtistName = a.ArtistName
            })
            .ToListAsync();

            if(artists == null || !artists.Any())
            {
                return NotFound("Artists NotFound");
            }

            return Ok(artists);
        }







        [HttpGet("Details", Name ="GetArtistsDetails")]
        public async Task<IActionResult> GetArtistsDetails()
        {
            var artists = await _context.Artists
            .Include(a => a.Songs)
            .Select(a => new ArtistDTO
            {
                ArtistId = a.ArtistId,
                ArtistName = a.ArtistName,
                Songs = a.Songs.Select(s => new ArtistDetailSongDTO 
            { 
                    SongId = s.SongId, 
                    SongName = s.SongName
            }).ToList()
            })    
            .ToListAsync();

            if(artists == null)
            {
                return NotFound("Artists NotFound");
            }

            return Ok(artists);
        }







        [HttpGet("{id}/Details", Name ="GetArtistDetails")]
        public async Task<IActionResult> GetArtistDetail(int id)
        {
            var artist = await _context.Artists
            .Include(a => a.Songs)
            .ThenInclude(a => a.Chords)
            .Where(a => a.ArtistId == id)
            .Select(a => new ArtistDTO
            {
                ArtistId = a.ArtistId,
                ArtistName = a.ArtistName,
                Songs = a.Songs.Select(s => new ArtistDetailSongDTO 
            { 
                    SongId = s.SongId, 
                    SongName = s.SongName
            }).ToList()
            })    
            .FirstOrDefaultAsync();
            
            if(artist == null)
            {
                return NotFound("Artist NotFound");
            }

            return Ok(artist);
            
        }        
    }
}