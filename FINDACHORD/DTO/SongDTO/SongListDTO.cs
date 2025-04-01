
namespace FINDACHORD.DTO
{
    public class SongListDTO
    {
        public int SongId { get; set; }
        public string? SongName { get; set; }
        public int ArtistId { get; set; } 
        public string? ArtistName { get; set; }

        internal object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}