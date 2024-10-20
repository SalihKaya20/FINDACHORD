namespace FINDACHORD.DTO
{
    public class ArtistDTO
    {
        public int ArtistId { get; set; }
        public string? ArtistName { get; set; }

        public List<ArtistDetailSongDTO> Songs { get; set; } = null!;

    }
}