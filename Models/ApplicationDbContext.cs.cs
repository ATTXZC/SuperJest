using Microsoft.EntityFrameworkCore;

namespace Eco_life.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cadastros1> Cadastros1 { get; set; }
        public DbSet<Produtos1> Produtos1 { get; set; }
        public DbSet<Funcionario1> Funcionarios1 { get; set; }

        internal bool TestConnection()
        {
            throw new NotImplementedException();
        }
    }
}
