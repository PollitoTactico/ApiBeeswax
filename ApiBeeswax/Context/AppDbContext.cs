using ApiBeeswax.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiBeeswax.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {


        }
        public DbSet<Producto> Productos { get; set; }
    }
    
}
