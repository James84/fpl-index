using FantasyLeague.Domain;
using FantasyLeague.ElasticSearch.Interfaces;
using Nest;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyLeague.ElasticSearch
{
    public class PlayerSearchService : ISearchService<Player, PlayerSearchCriteria>
    {
        private readonly ElasticClient _elasticClient;
        
        public PlayerSearchService()
        {
            _elasticClient = ElasticSearchClientFactory.Create();
        }

        public async Task<IEnumerable<Player>> GetAll(int skip = 0, int take = 100)
        {
            var results = await _elasticClient.SearchAsync<Player>(s => s.Skip(skip)
                                                                         .Size(take)
                                                                         .Query(q => q.MatchAll()));

            return results.Documents;
        }

        public async Task<IEnumerable<Player>> SearchQuery(PlayerSearchCriteria criteria)
        {
            var results = await _elasticClient.SearchAsync<Player>(s => s.Size(100)
                .Query(q => q.Match(m => m.Field(p => p.SecondName).Query(criteria.LastName))));


            return results.Documents;
        }

        public async Task<IEnumerable<Player>> PrefixSearchQuery(PlayerSearchCriteria criteria)
        {
            var results = await _elasticClient.SearchAsync<Player>(s => s.Size(100)
                                                                         .Query(q => q.Prefix(m => m.Field(p => p.SecondName)
                                                                                                    .Value(criteria.LastName))));


            return results.Documents;
        }

        public async Task<Player> SearchById(int id)
        {
            var results = await _elasticClient.SearchAsync<Player>(s => s.Size(1)
                .Query(q => q.Match(m => m.Field(p => p.Id).Query(id.ToString()))));


            return results.Documents.Single();
        }
    }
}
