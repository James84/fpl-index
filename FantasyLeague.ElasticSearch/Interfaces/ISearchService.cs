using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nest;

namespace FantasyLeague.ElasticSearch.Interfaces
{
    public interface ISearchService
    {
        Task<IEnumerable<T>> Search<T>(/*Func<QueryContainerDescriptor<T>, QueryContainer> query*/) where T : class;
        Task<IEnumerable<T>> SearchQuery<T>(Func<QueryContainerDescriptor<T>, QueryContainer> query) where T : class;
    }
}
