using Microsoft.EntityFrameworkCore;

namespace MinimalAPI
{
    public class TodoDB : DbContext
    {
        //<TotoDB> options
        public TodoDB(DbContextOptions options) : base(options)
        {
        }

        protected TodoDB()
        {
        }

        public DbSet<Todo> Todos => Set<Todo>(); 


    }
}
