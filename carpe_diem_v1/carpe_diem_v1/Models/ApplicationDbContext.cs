using Microsoft.EntityFrameworkCore;

namespace carpe_diem_v1.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Hospede> Hospedes { get; set; }
    }
}
