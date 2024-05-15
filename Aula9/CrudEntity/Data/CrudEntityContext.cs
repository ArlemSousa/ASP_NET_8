using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudEntity.Models;

namespace CrudEntity.Data
{
    public class CrudEntityContext : DbContext
    {
        public CrudEntityContext (DbContextOptions<CrudEntityContext> options)
            : base(options)
        {
        }

        public DbSet<Funcionario> Funcionario { get; set; } = default!;
    }
}
