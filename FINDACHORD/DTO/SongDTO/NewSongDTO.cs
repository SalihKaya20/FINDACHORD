namespace FINDACHORD.DTO
{
    public class NewSongDTO
    {
        public int SongId { get; set; }
        public string? SongName { get; set; }
        public int ArtistId { get; set; } 
        public string? ArtistName { get; set; }
        public DateTime AddedDate { get; set; }
        
        
    }
}