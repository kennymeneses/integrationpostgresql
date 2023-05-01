using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class BetDbContext : DbContext
    {
        public BetDbContext(DbContextOptions<BetDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<Matches> Matches { get; set; }
    }

    public class Matches
    {
        public int Id { get; set; }
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public DateTime Fecha { get; set; }
        public int ResultadoLocal { get; set; }
        public int ResultadoVisitante { get; set; }

    }
}
