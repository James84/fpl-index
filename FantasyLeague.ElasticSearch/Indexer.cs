using System;
using FantasyLeague.ElasticSearch.Interfaces;
using Nest;
using System.Collections.Generic;
using System.Threading.Tasks;
using FantasyLeague.Domain;

namespace FantasyLeague.ElasticSearch
{
    public class Indexer: IIndexer
    {
        private readonly ElasticClient _elasticClient;

        public Indexer()
        {
            _elasticClient = ElasticSearchClientFactory.Create();
        }

        public async Task Index<T>(IEnumerable<T> data) where T : class
        {
            foreach (var entity in data)
            {
                await Index(entity);
            }
        }

        public async Task Index<T>(IEnumerable<T> data, Func<T, T> map) where T : class
        {
            foreach (var entity in data)
            {
                var mutatedEntity = map(entity);
                await Index(mutatedEntity);
            }
        }

        public async Task DeleteIndex(string index)
        {
            var deleteResponse = await _elasticClient.DeleteIndexAsync(new DeleteIndexRequest(index));
            ;
        }

        private async Task Index<T>(T data) where T: class
        {
            var indexResponse = await _elasticClient.IndexDocumentAsync(data);
        }
    }
}
