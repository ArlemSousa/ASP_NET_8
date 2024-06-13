using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VendasProdutos.Models;

namespace VendasProdutos.Data
{
    public class VendasProdutosContext : DbContext
    {
        public VendasProdutosContext (DbContextOptions<VendasProdutosContext> options)
            : base(options)
        {
        }

        public DbSet<VendasProdutos.Models.Produto> Produto { get; set; } = default!;
        public DbSet<VendasProdutos.Models.Venda> Venda { get; set; } = default!;
    }
}
