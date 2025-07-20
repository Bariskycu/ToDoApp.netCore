using Microsoft.EntityFrameworkCore;
using ToDoAPP.Models;

namespace ToDoAPP.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Todo> Todos { get; set; }
    }
}
