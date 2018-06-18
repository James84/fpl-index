using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FantasyLeague.ElasticSearch.Interfaces
{
    public interface IIndexer
    {
        Task Index<T>(IEnumerable<T> data) where T : class;
        Task Index<T>(IEnumerable<T> data, Func<T, T> map) where T : class;
        Task DeleteIndex(string index);
    }
}
