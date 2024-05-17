using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExercicioAula11_CadastroAluno.Models;

namespace ExercicioAula11_CadastroAluno.Data
{
    public class CadastroAlunoContext : DbContext
    {
        public CadastroAlunoContext (DbContextOptions<CadastroAlunoContext> options)
            : base(options)
        {
        }

        public DbSet<Aluno> Aluno { get; set; } = default!;
    }
}
