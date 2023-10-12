using HerramientasApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HerramientasApi.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Herramienta> Herramientas { get; set; }
    }
}
