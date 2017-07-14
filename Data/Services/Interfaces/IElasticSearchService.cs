using Elasticsearch.Net;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BbmUnderlakare.Data.Services.Interfaces
{
    public interface IElasticSearchService<T> where T : class
    {
        void ReCreateIndex();
        ISearchResponse<T> Search(Func<SearchDescriptor<T>, ISearchRequest> selector = null);
        Task<string> AddToIndexAsync(T obj, Refresh refresh = Refresh.False);
        string AddToIndex(T obj, Refresh refresh = Refresh.False);
        void RefreshIndex();
        string Upsert(string id, T obj);
    }
}