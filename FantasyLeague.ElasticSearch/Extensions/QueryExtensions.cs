using System;
using System.Collections.Generic;
using System.Text;
using Nest;

namespace FantasyLeague.ElasticSearch.Extensions
{
    public static class QueryExtensions
    {
        public static MatchQueryDescriptor<T> BuildMatchQuery<T>(this MatchQueryDescriptor<T> matchQuery,
                                                                  Func<T, object> fieldSelector,
                                                                  string term,
                                                                  string queryName) where T : class
        {
            return matchQuery.Field(p => fieldSelector)
                .Analyzer("standard")
                .Boost(1.1)
                .CutoffFrequency(0.001)
                .Query(term)
                .Fuzziness(Fuzziness.Auto)
                .Lenient()
                .FuzzyTranspositions()
                .MinimumShouldMatch(2)
                .Operator(Operator.Or)
                .FuzzyRewrite(MultiTermQueryRewrite.TopTermsBlendedFreqs(10))
                .Name(queryName);
        }
    }
}
