namespace FINDACHORD.DTO
{
    public class PopularSongDTO
    {
        public int SongId { get; set; }
        public string? SongName { get; set; }
        public int ArtistId { get; set; } 
        public string? ArtistName { get; set; }
        public int ViewCount { get; set; }

        
        
    }
}