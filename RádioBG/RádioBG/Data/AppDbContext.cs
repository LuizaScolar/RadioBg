using Microsoft.EntityFrameworkCore;
using RadioBG.Models; 

namespace RadioBG.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Musica> Musicas { get; set; }
        
    }
}