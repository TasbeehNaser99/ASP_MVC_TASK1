using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
namespace WebApplication2.Data
{
    public class ApplicationDbContext : DbContext
    {
       public DbSet<Employee> Employees {  get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=ASPMVCT1;trusted_connection=true;trustServerCertificate=true");
        }
    }
}
