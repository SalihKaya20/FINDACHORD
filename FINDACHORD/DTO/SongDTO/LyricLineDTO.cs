namespace FINDACHORD.DTO
{
    public class LyricLineDTO
    {
        public List<ChordPositionDTO> Chords { get; set; } = new List<ChordPositionDTO>();
        public string Lyrics { get; set; } = string.Empty;
    }

    
}