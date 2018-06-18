using FantasyLeague.ElasticSearch.Interfaces;
using Nest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasyLeague.ElasticSearch
{
    public class SearchService : ISearchService
    {
        private readonly ElasticClient _elasticClient;

        public SearchService()
        {
            _elasticClient = ElasticSearchClientFactory.Create();
        }

        public async Task<IEnumerable<T>> Search<T>() where T : class
        {
            var results = await _elasticClient.SearchAsync<T>(s => s.From(0)
                                                                    .Size(10000)
                                                                    .Query(q => q.MatchAll()));

            return results.Documents;
        }

        public async Task<IEnumerable<T>> SearchQuery<T>(Func<QueryContainerDescriptor<T>, QueryContainer> query) where T: class
        {
            var results = await _elasticClient.SearchAsync<T>(s => s.Size(10000).Query(query));

            return results.Documents;
        }
    }
}
