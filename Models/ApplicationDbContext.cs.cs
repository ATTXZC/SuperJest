using Microsoft.EntityFrameworkCore;

namespace Eco_life.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cadastros> Cadastros { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        internal bool TestConnection()
        {
            throw new NotImplementedException();
        }
    }
}
