using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Aviones> Aviones { get; set; }
        public DbSet<Pilotos> Pilotos { get; set; }
        public DbSet<PilotoAviones> PilotoAviones{ get; set; }
        public DbSet<Hangares> Hangares { get; set; }
    }
}
