﻿using FantasyLeague.Domain;
using FantasyLeague.ElasticSearch.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasyLeague.ElasticSearch
{
    public class TeamSearchService : ISearchService<Team>
    {
        public Task<IEnumerable<Team>> Search()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Team>> SearchQuery(PlayerSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }

        public Task<Player> SearchById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Player>> PrefixSearchQuery(PlayerSearchCriteria criteria)
        {
            throw new NotImplementedException();
        }
    }
}
