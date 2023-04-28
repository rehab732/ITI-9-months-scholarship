using Microsoft.EntityFrameworkCore;
using TranieeLibrary;

namespace TrennieWebApi.Models
{
    public class TranieeDBContext:DbContext
    {
        public TranieeDBContext(DbContextOptions<TranieeDBContext>option) : base(option) { }

        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<Treniee> Treniees { get; set; }

    }
}
