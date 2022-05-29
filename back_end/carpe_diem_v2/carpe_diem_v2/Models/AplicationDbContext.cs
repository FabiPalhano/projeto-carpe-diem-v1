using Microsoft.EntityFrameworkCore;

namespace carpe_diem_v2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<CadastroImovel> CadastroImovel { get; set; }
    }
}
