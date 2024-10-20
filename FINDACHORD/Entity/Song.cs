namespace FINDACHORD.Entity
{
    public class Song
    {
        public int SongId { get; set; }
        public string? SongName { get; set; }
        public string? LyricsWithChords { get; set; }

        
        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }
        

        public int ViewCount { get; set; }

        public DateTime AddedDate { get; set; }


        
        public ICollection<Chord> Chords {get; set;} = new List<Chord>();
        
        
    
    }
}