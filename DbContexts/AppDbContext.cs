using ApiReparacion.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiReparacion.DbContexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions opt) : base(opt)
        {

        }
        public DbSet<Reparacion> reparacion { get; set; }
        public DbSet<DetalleReparacion> detalleReparacion { get; set; }
    }
}
