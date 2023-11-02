using Microsoft.Data.SqlClient;
using PS.All_Films.Web.BusinessLogic.Interfaces;
using PS.All_Films.Web.Models;

namespace PS.All_Films.Web.BusinessLogic.Repositories
{
    public class MovieRepository : IMovie
    {
        public Task<Movie> DeleteAsync(Movie unit)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> EditAsync(Movie unit)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetItemAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PaginatedList<Movie>> GetItemsAsync(string sortProperty, SortOrder order, string searchText, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GreateAsync(Movie unit)
        {
            throw new NotImplementedException();
        }
    }
}
