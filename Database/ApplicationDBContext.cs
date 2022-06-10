using Microsoft.EntityFrameworkCore;
using ProjetoAcademia.Models;

namespace ProjetoAcademia.Database
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base (options){
        }
    }
}