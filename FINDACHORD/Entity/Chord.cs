namespace FINDACHORD.Entity
{
    public class Chord
    {
        public int ChordId { get; set; }
        public string? ChordName { get; set; }
        

        public ICollection<Song> Songs {get ; set;} = new List<Song>();
    }
}