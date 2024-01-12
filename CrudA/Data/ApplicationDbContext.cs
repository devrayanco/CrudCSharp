using CrudA.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudA.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<CadastroModel> Cadastro { get; set; }
    }
}
