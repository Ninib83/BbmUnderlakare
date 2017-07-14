using BbmUnderlakare.Data.Context;
using BbmUnderlakare.Data.Entities.ElasticSearch.Interfaces;
using BbmUnderlakare.Data.Extensions;
using BbmUnderlakare.Data.Services.Interfaces;
using Elasticsearch.Net;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BbmUnderlakare.Data.Services
{
    public class ElasticSearchPageWatcherService : IPageWatcherService
    {
        private readonly IElasticClient _client;
        private readonly string _index;

        public ElasticSearchPageWatcherService()
        {
            _client = ElasticSearchPageWatcherContext.GetClient();
            _index = ElasticSearchPageWatcherContext.Index;
        }

        public void ReCreateIndex()
        {
            var indexExists = _client.IndexExists(_index);
            if (indexExists.Exists)
            {
                _client.DeleteIndex(_index);
            }

            var response = _client.CreateIndex(_index, x => x
                .Mappings(m => m
                    .Map<IWatchedPageQuery>(mm => mm.AutoMap())
                    .Map<IPageWatcher>(mm => mm.AutoMap()
                        .Properties(p => p
                            .Percolator(pp => pp.Name(n => n.Query))
                        )
                    )
                )
            );

            response.Validate();
        }

        public async Task<string> CreatePageWatcherAsync(IPageWatcher pageWatcher)
        {
            var createdResponse = await _client.IndexAsync(pageWatcher, x => x.Refresh(Refresh.True));

            createdResponse.Validate();

            return createdResponse.Id;
        }

        public async Task<string> UpdatePageWatcherAsync(IPageWatcher pageWatcher, Refresh refresh = Refresh.True)
        {
            if (string.IsNullOrWhiteSpace(pageWatcher.Id))
            {
                throw new ArgumentNullException(nameof(pageWatcher.Id));
            }

            var updateResponse = await _client.UpdateAsync<IPageWatcher, IPageWatcher>(DocumentPath<IPageWatcher>.Id(pageWatcher.Id), d => d.DocAsUpsert().Doc(pageWatcher).Refresh(refresh));

            updateResponse.Validate();

            return updateResponse.Id;
        }

        public void RefreshIndex()
        {
            var response = _client.Refresh(_index);

            response.Validate();
        }

        public async Task DeletePageWatcherAsync(Guid userId, string pageWatcherId)
        {
            var result = await _client.DeleteAsync<IPageWatcher>(pageWatcherId);
            result.Validate();
        }

        public IEnumerable<IPageWatcher> MatchPageWatchers(IWatchedPageQuery publishedPage)
        {
            var result = _client.Search<IPageWatcher>(s => s
                .Query(q => q
                    .Percolate(p => p
                        .Field(f => f.Query)
                        .DocumentType<IWatchedPageQuery>()
                        .Document(publishedPage)
                    )
                )
            );

            result.Validate();

            return result.Documents;
        }
    }
}