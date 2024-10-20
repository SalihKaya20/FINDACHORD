using FINDACHORD.Entity;
using Microsoft.EntityFrameworkCore;

namespace FINDACHORD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Chord> Chords => Set<Chord>();
        public DbSet<Song> Songs => Set<Song>() ;
        public DbSet<Artist> Artists => Set<Artist>();
        
    }
}