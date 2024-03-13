
using ControlePonto.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ControlePonto.Data
{
    internal class ControlePontoDbContext : DbContext
    {
        public ControlePontoDbContext(DbContextOptions<ControlePontoDbContext> options) : base(options)
        {

        }

        public DbSet<Cargo> Cargos { get; set; }

        
        public override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
