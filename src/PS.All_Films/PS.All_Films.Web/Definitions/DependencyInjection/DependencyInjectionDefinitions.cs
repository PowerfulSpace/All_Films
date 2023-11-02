using PS.All_Films.Web.BusinessLogic.Interfaces;
using PS.All_Films.Web.BusinessLogic.Repositories;
using PS.All_Films.Web.Definitions.Base;

namespace PS.All_Films.Web.Definitions.DependencyInjection
{
    public class DependencyInjectionDefinitions : AppDefinitions
    {
        public override void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMovie, MovieRepository>();
        }
    }
}
