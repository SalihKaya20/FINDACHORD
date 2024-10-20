using FINDACHORD.Data;
using FINDACHORD.DTO;
using FINDACHORD.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FINDACHORD.Controllers
{   

    [ApiController]
    [Route("api/[controller]")]
    public class SongController : ControllerBase
    {

        private readonly DataContext _context ;

        public SongController(DataContext context)
        {
            _context =context;
        }
        



        [HttpGet("SongList", Name = "GetSongsList")]
        public async Task<IActionResult> GetSongsList()
        {
            var songs = await _context.Songs
                .Include(s => s.Artist)
                .Select(s => new SongListDTO
                {
                    SongId = s.SongId,
                    SongName =s.SongName,
                    ArtistId = s.ArtistId,
                    ArtistName = s.Artist != null ? s.Artist.ArtistName : null
                    
           
                }).ToListAsync();

                if(songs == null)
                {
                    return NotFound();
                }

                var missingArtists = songs.Where(s => s.ArtistId == 0).ToList();

                if (missingArtists.Any())
                {
                    return NotFound("The artist of some songs could not be found");
                }

                return Ok(songs);
        }








        [HttpGet("{id}/Songid", Name = "GetSong")]
        public async Task<IActionResult> GetSong(int id)
        {
            var song = await _context.Songs
                .Include(s => s.Artist)
                .Where(s => s.SongId == id)
                .Select(s => new SongListDTO
                {
                    SongId = s.SongId,
                    SongName = s.SongName,
                    ArtistId = s.ArtistId,
                    ArtistName = s.Artist !=null ? s.Artist.ArtistName : null
                }).FirstOrDefaultAsync();

                if(song == null)
                {
                    return NotFound();
                }

                if (song.ArtistId == 0)
                {
                    return NotFound("The artist of this song could not be found");
                }
                
                return Ok(song);
        }







        [HttpPost("{id}/IncrementViewCount")]
        public async Task<IActionResult> IncrementViewCount(int id)
        {
            var song = await _context.Songs.FindAsync(id);

            if (song == null)
            {
                return NotFound();
            }

            song.ViewCount++;
            await _context.SaveChangesAsync();
            return Ok();
        }







        [HttpGet("Popular", Name = "GetPopularSongs")]
        public async Task<IActionResult> GetPopularSongs()
        {
            var popularSongs = await _context.Songs
                .Include(a => a.Artist)
                .OrderByDescending(s => s.ViewCount) 
                .Take(20) 
                .Select(s => new PopularSongDTO
                {
                    SongId = s.SongId,
                    SongName = s.SongName,
                    ArtistId = s.ArtistId,
                    ArtistName = s.Artist != null ? s.Artist.ArtistName : null
                })
                .ToListAsync();

            if (popularSongs == null || !popularSongs.Any())
            {
                return NotFound("Popular Songs NotFound");
            }

            return Ok(popularSongs);
        }
        




        

        [HttpGet("New", Name ="GetNewSongs")]
        public async Task<IActionResult> GetNewSongs()
        {
            var newSongs = await _context.Songs
            .Include(a => a.Artist)
            .OrderByDescending(s => s.SongId)
            .Take(20)
            .Select(s => new NewSongDTO
            {
                SongId = s.SongId,
                SongName = s.SongName,
                ArtistId = s.ArtistId,
                ArtistName = s.Artist != null ? s.Artist.ArtistName : null
            }).ToListAsync();

            if(newSongs ==null || !newSongs.Any())
            {
                return NotFound();
            }

            return Ok(newSongs);
        }







        [HttpGet("Details", Name = "GetSongsDetails")]
        public async Task<IActionResult> GetSongsDetails()
        {
            var songs = await _context.Songs
            .Include(s => s.Artist)
            .Include(s => s.Chords)
            .Select(s => new SongDTO
            {
                SongId = s.SongId,
                SongName = s.SongName,               
                ArtistId = s.Artist != null ? s.Artist.ArtistId : 0,
                ArtistName = s.Artist != null ? s.Artist.ArtistName : null,
                LyricsWithChords = s.LyricsWithChords != null ? ParseLyricsWithChords(s.LyricsWithChords) : null
                              
            })
            .ToListAsync();


            if(songs == null || !songs.Any())
            {
                return NotFound("Songs NotFound");
            }


            var missingArtists = songs.Where(s => s.ArtistId == 0).ToList();

            if (missingArtists.Any())
            {
                return NotFound("The artist of some songs could not be found");
            }

            return Ok(songs);
        }







        [HttpGet("{id}/details", Name ="GetSongDetail")]
        public async Task<IActionResult> GetSongDetail(int id)
        {
            var song = await _context.Songs
            .Include(s => s.Artist)
            .Include(s => s.Chords)
            .Where(s => s.SongId == id)
            .Select(s => new SongDTO
            {
                SongId = s.SongId,
                SongName = s.SongName,
                ArtistId = s.Artist != null ? s.Artist.ArtistId : 0,
                ArtistName = s.Artist != null ? s.Artist.ArtistName : null,
                LyricsWithChords = s.LyricsWithChords != null ? ParseLyricsWithChords(s.LyricsWithChords) : null
                
            })
            .FirstOrDefaultAsync();

            if(song == null)
            {
                return NotFound("Song NotFound");
            }

            if (song.ArtistId == 0)
            {
                return NotFound("Artist NotFound");
            }

            return Ok(song);
        }






        private static List<LyricLineDTO> ParseLyricsWithChords(string lyricsWithChords)
        {
            var result = new List<LyricLineDTO>();
            var lines = lyricsWithChords.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            foreach (var line in lines)
            {
                var lyricLine = new LyricLineDTO();
                var parts = line.Split(new[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);

                string lyrics = "";
                for (int i = 0; i < parts.Length; i++)
                {
                    if (i % 2 == 0) // Söz
                    {
                        lyrics += parts[i];
                    }
                    else // Akor
                    {
                        var chordParts = parts[i].Split(':');
                        if (chordParts.Length == 2 && int.TryParse(chordParts[1], out int position))
                        {
                            lyricLine.Chords.Add(new ChordPositionDTO 
                            { 
                                Chord = chordParts[0], 
                                Position = position 
                            });
                        }
                    }
                }

                lyricLine.Lyrics = lyrics.Trim();
                result.Add(lyricLine);
            }

            return result;
        }






        [HttpGet("Search", Name ="Search")]
        public async Task<IActionResult> Search(string query)
        {
            if(string.IsNullOrWhiteSpace(query))
            {
                return BadRequest("Search query cannot be empty.");
            }

            query =query.ToLower();

            var searchResults = await _context.Songs
                .Include(a => a.Artist)
                .Where(s => (s.SongName != null && s.SongName.ToLower().Contains(query)) || 
                    (s.Artist != null && s.Artist.ArtistName != null && s.Artist.ArtistName.ToLower().Contains(query)))
                .Select(s => new SearchDTO
                {
                    SongId = s.SongId,
                    SongName = s.SongName,
                    ArtistId = s.Artist != null ? s.Artist.ArtistId : 0,
                    ArtistName = s.Artist != null ? s.Artist.ArtistName : null,
                    Type = "Song"       
                })
                .Take(10)
                .ToListAsync();
            

            var artistResults = await _context.Artists
                .Include(s => s.Songs)
                .Where(a => a.ArtistName != null && a.ArtistName.ToLower().Contains(query))
                .Select(s => new SearchDTO
                {   
                    ArtistId = s.ArtistId,
                    ArtistName = s.ArtistName,
                    Type = "Artist"
                })
                .Take(5)
                .ToListAsync();

             if(!searchResults.Any() && !artistResults.Any())
             {
                return NotFound("No search results found.");
             }
             
            searchResults.AddRange(artistResults);

            return Ok(searchResults);

        }   
    }
}
