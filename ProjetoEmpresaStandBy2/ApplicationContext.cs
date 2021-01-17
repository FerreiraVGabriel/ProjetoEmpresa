using Microsoft.EntityFrameworkCore;
using ProjetoEmpresaStandBy2.Models;

namespace ProjetoEmpresaStandBy2
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }

        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>().HasKey(t => t.ClienteId);

        }
    }

}