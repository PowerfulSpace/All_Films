using Microsoft.EntityFrameworkCore;
using PS.All_Films.Web.Data;
using PS.All_Films.Web.Definitions.Base;

namespace PS.All_Films.Web.Definitions.DbContext
{
    public class DbContextDefinition : AppDefinitions
    {
        public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(x => x.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        }
    }
}
