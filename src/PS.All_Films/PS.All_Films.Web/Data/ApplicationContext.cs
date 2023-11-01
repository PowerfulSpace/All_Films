using Microsoft.EntityFrameworkCore;
using PS.All_Films.Web.Models;

namespace PS.All_Films.Web.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; } = null!;
    }
}
