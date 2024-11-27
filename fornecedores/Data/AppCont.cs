using Microsoft.EntityFrameworkCore;
using fornecedores.Models.MaisFornec;

namespace Fornecedores.Data
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options)
        {

        }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}