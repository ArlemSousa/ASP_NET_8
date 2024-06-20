
using API_JWT.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API_JWT.Controllers.Data
{
    public class APICatalogContext : IdentityDbContext<ApplicationUser>
    {
        public APICatalogContext(DbContextOptions<APICatalogContext> options) : base(options) { }


        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Produto> produtos { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
