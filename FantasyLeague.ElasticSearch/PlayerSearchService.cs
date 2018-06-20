using FantasyLeague.Domain;
using FantasyLeague.ElasticSearch.Extensions;
using FantasyLeague.ElasticSearch.Interfaces;
using Nest;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasyLeague.ElasticSearch
{
    public class PlayerSearchService : ISearchService<Player>
    {
        private readonly ElasticClient _elasticClient;
        
        public PlayerSearchService()
        {
            _elasticClient = ElasticSearchClientFactory.Create();
        }

        public async Task<IEnumerable<Player>> Search()
        {
            var results = await _elasticClient.SearchAsync<Player>(s => s.From(0)
                                                                    .Size(10000)
                                                                    .Query(q => q.MatchAll()));

            return results.Documents;
        }

        public async Task<IEnumerable<Player>> SearchQuery(PlayerSearchCriteria criteria)
        {
            var results = await _elasticClient.SearchAsync<Player>(s => s.Size(10000)
                                                                         .Query(q => q.Match(m => m.Field(p => p.SecondName)
                                                                                                   .Analyzer("standard")
                                                                                                   .Boost(1.1)
                                                                                                   .CutoffFrequency(0.001)
                                                                                                   .Query(criteria.LastName)
                                                                                                   .Fuzziness(Fuzziness.Auto)
                                                                                                   .Lenient()
                                                                                                   .FuzzyTranspositions()
                                                                                                   .MinimumShouldMatch(2)
                                                                                                   .Operator(Operator.Or)
                                                                                                   .FuzzyRewrite(MultiTermQueryRewrite.TopTermsBlendedFreqs(10))
                                                                                                   .Name("lastName"))));

            return results.Documents;
        }
    }
}
