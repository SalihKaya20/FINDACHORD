namespace FINDACHORD.Entity
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string? ArtistName { get; set; } 


        public ICollection<Song> Songs {get; set;} = new List<Song>();
    }
}