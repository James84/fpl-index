using FantasyLeague.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasyLeague.ElasticSearch.Interfaces
{
    public interface ISearchService<T> where T : class
    {
        Task<IEnumerable<T>> Search( /*Func<QueryContainerDescriptor<T>, QueryContainer> query*/);
        Task<IEnumerable<T>> SearchQuery(PlayerSearchCriteria criteria);
        Task<Player> SearchById(int id);
        Task<IEnumerable<Player>> PrefixSearchQuery(PlayerSearchCriteria criteria);
    }
}
