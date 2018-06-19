﻿using FantasyLeague.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasyLeague.ElasticSearch.Interfaces
{
    public interface ISearchService<T> where T : class
    {
        Task<IEnumerable<T>> Search( /*Func<QueryContainerDescriptor<T>, QueryContainer> query*/);
        Task<IEnumerable<T>> SearchQuery(PlayerSearchCriteria criteria);
    }
}
