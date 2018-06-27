using FantasyLeague.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasyLeague.ElasticSearch.Interfaces
{
    public interface ISearchService<T> where T : class
    {
        Task<IEnumerable<Player>> GetAll(int skip = 0, int take = 100);
        Task<IEnumerable<T>> SearchQuery(PlayerSearchCriteria criteria);
        Task<Player> SearchById(int id);
        Task<IEnumerable<Player>> PrefixSearchQuery(PlayerSearchCriteria criteria);
    }
}
