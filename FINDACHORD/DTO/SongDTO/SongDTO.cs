namespace FINDACHORD.DTO
{
    public class SongDTO
    {
        public int SongId { get; set; }
        public string? SongName { get; set; }
        public int ArtistId { get; set; }
        public string? ArtistName { get; set; }
        public List<LyricLineDTO>? LyricsWithChords { get; set; }

        
    }

       



}