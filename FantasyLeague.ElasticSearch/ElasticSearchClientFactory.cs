using FantasyLeague.Domain;
using Nest;
using System;

namespace FantasyLeague.ElasticSearch
{
    public static class ElasticSearchClientFactory
    {
        public static ElasticClient Create()
        {
            var settings = new ConnectionSettings(new Uri("http://localhost:9400"))
                            .DefaultMappingFor<Player>(m => m.IndexName("players"))
                            .DefaultMappingFor<Team>(m => m.IndexName("team"))
                            .DefaultIndex("candidate");

            return new ElasticClient(settings);
        }
    }
}
