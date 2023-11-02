using Microsoft.Data.SqlClient;
using PS.All_Films.Web.Models;

namespace PS.All_Films.Web.BusinessLogic.Interfaces.Base
{
    public interface IBaseRepository<T>
    {
        Task<PaginatedList<T>> GetItemsAsync(string sortProperty, SortOrder order, string searchText, int pageIndex, int pageSize);
        Task<T> GetItemAsync(Guid id);
        Task<T> GreateAsync(T unit);
        Task<T> EditAsync(T unit);
        Task<T> DeleteAsync(T unit);
    }
}
