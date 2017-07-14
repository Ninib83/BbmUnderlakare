using BbmUnderlakare.Data.Converters;
using BbmUnderlakare.Data.Entities.ElasticSearch.Interfaces;
using Nest;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BbmUnderlakare.Data.Context
{
    public class ElasticSearchPageWatcherContext
    {
        private static string _index;
        public static string Index
        {
            get
            {
                if (_index == null)
                {
                    const string key = "ElasticSearchPageWatchersIndex";
                    var indexName = ConfigurationManager.AppSettings[key];
                    if (string.IsNullOrWhiteSpace(indexName))
                    {
                        throw new NullReferenceException($"\"{key}\" must exist in appsettings");
                    }
                    _index = indexName;
                }

                return _index;
            }
        }

        private static IElasticClient _client;
        public static IElasticClient GetClient()
        {
            if (_client == null)
            {
                var connectionSettings = ElasticSearchSettings.GetDefaultConnectionSettings()
                    .DefaultIndex(Index)
                    .InferMappingFor<IWatchedPageQuery>(m => m
                        .TypeName(nameof(IWatchedPageQuery)))
                    .InferMappingFor<IPageWatcher>(m => m
                        .TypeName(nameof(IPageWatcher)));

                _client = new ElasticClient(connectionSettings);
            }

            return _client;
        }

    }
}