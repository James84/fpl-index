using FantasyLeague.Domain;
using FantasyLeague.ElasticSearch.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nest;

namespace FantasyLeague.ElasticSearch
{
    public class TeamSearchService : ISearchService<Team, TeamSearchCriteria>
    {
        private readonly ElasticClient _elasticClient;

        public TeamSearchService()
        {
            _elasticClient = ElasticSearchClientFactory.Create();
        }

        public async Task<IEnumerable<Team>> GetAll(int skip = 0, int take = 100)
        {
           var request = await _elasticClient.SearchAsync<Team>(s => s.Skip(skip)
                                                                      .Take(take)
                                                                      .MatchAll());

            return request.Documents;
        }

        public Task<IEnumerable<Team>> SearchQuery(TeamSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }

        public Task<Team> SearchById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Team>> PrefixSearchQuery(TeamSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }
    }
}
