using Microsoft.EntityFrameworkCore;
using TesteBRQ.Domain.Entities;

namespace TesteBRQ.Infra.Data.Context
{
    public class TesteBRQContext : DbContext
    {
        public TesteBRQContext(DbContextOptions<TesteBRQContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasIndex(p => new { p.id })
                .IsUnique(true);
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
