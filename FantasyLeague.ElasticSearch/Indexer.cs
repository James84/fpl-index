using FantasyLeague.ElasticSearch.Interfaces;
using Nest;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task DeleteIndex(string index)
        {
            await _elasticClient.DeleteIndexAsync(index);
        }

        private async Task Index<T>(T data) where T: class
        {
            await _elasticClient.IndexDocumentAsync(data);
        }
    }
}
