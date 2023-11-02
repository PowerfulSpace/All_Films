using Microsoft.Data.SqlClient;
using PS.All_Films.Web.BusinessLogic.Interfaces;
using PS.All_Films.Web.Data;
using PS.All_Films.Web.Models;

namespace PS.All_Films.Web.BusinessLogic.Repositories
{
    public class MovieRepository : IMovie
    {
        private readonly ApplicationContext _context;

        public MovieRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<Movie>> GetItemsAsync(string sortProperty, SortOrder order, string searchText, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<Movie> GetItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Movie> DeleteAsync(Movie unit)
        {
            throw new NotImplementedException();
        }

        public async Task<Movie> EditAsync(Movie unit)
        {
            throw new NotImplementedException();
        }

        public async Task<Movie> GreateAsync(Movie unit)
        {
            throw new NotImplementedException();
        }
    }
}
