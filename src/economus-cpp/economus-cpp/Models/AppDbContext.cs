using Microsoft.EntityFrameworkCore;
using economus_cpp.Models;

namespace economus_cpp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<economus_cpp.Models.Investimento> Investimento { get; set; }
        public DbSet<economus_cpp.Models.Meta> Meta { get; set; }
        public DbSet<economus_cpp.Models.Receita> Receita { get; set; }
        public DbSet<economus_cpp.Models.Despesa> Despesa { get; set; }
    }
}