using BbmUnderlakare.Data.Entities.ElasticSearch.Interfaces;
using Elasticsearch.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BbmUnderlakare.Data.Services.Interfaces
{
    public interface IPageWatcherService
    {
        IEnumerable<IPageWatcher> MatchPageWatchers(IWatchedPageQuery publishedPage);
        Task<string> CreatePageWatcherAsync(IPageWatcher pageWatcher);
        Task DeletePageWatcherAsync(Guid userId, string pageWatcherId);
        Task<string> UpdatePageWatcherAsync(IPageWatcher pageWatcher, Refresh refresh = Refresh.True);
        void RefreshIndex();
        void ReCreateIndex();
    }
}