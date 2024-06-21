using Microsoft.EntityFrameworkCore;
using Sistema_de_Gerenciamento_de_Estados_de_Tarefas.Models;
namespace Sistema_de_Gerenciamento_de_Estados_de_Tarefas.Context
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }
        public DbSet<Tasks> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tasks>()
                .Property(t => t.State);

            base.OnModelCreating(modelBuilder);
        }
    }
}
