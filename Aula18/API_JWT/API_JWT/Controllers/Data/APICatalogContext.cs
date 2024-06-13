
using API_JWT.Models;
using Microsoft.EntityFrameworkCore;

namespace API_JWT.Controllers.Data
{
    public class APICatalogContext : DbContext
    {
        public APICatalogContext(DbContextOptions<APICatalogContext> options) : base(options) { }


        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Produto> produtos { get; set; }

    }
}
