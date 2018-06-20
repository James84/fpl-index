﻿using FantasyLeague.Domain;
using FantasyLeague.ElasticSearch.Interfaces;
using Nest;
using System.Collections.Generic;
using System.Linq;
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
                .Query(q => q.Match(m => m.Field(p => p.SecondName).Query(criteria.LastName))));


            return results.Documents;
        }

        public async Task<IEnumerable<Player>> PrefixSearchQuery(PlayerSearchCriteria criteria)
        {
            var results = await _elasticClient.SearchAsync<Player>(s => s.Size(10000)
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
