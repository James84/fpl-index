using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasyLeague.ElasticSearch.Interfaces
{
    public interface ISearchService<T, in TCriteria> where T : class
    {
        Task<IEnumerable<T>> GetAll(int skip = 0, int take = 100);
        Task<IEnumerable<T>> SearchQuery(TCriteria criteria);
        Task<T> SearchById(int id);
        Task<IEnumerable<T>> PrefixSearchQuery(TCriteria criteria);
    }
}
