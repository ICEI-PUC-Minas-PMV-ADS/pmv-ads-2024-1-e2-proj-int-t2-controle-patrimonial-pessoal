using Microsoft.EntityFrameworkCore;
using economus_cpp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace economus_cpp.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Investimento> Investimento { get; set; }
        public DbSet<Meta> Meta { get; set; }
        public DbSet<Receita> Receita { get; set; }
        public DbSet<Despesa> Despesa { get; set; }
    }
}